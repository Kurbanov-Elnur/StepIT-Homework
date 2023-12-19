using _5.Fabrics.Classes;
using _5.Services.Classes;
using _5.Services.Interfaces;
using _5.ViewModels;
using _5.Views;
using GalaSoft.MvvmLight.Messaging;
using SimpleInjector;
using System.Configuration;
using System.Data;
using System.Transactions;
using System.Windows;

namespace _5;


public partial class App : Application
{
    public static Container Container { get; set; } = new();

    public void Register()
    {
        Container.RegisterSingleton<IMessenger, Messenger>();
        Container.RegisterSingleton<IDataService, DataService>();
        Container.RegisterSingleton<INavigationService, NavigationService>();

        Container.RegisterSingleton<HomeTaskFactory>();

        Container.RegisterSingleton<AllTasksViewModel>();
        Container.RegisterSingleton<MainWindowViewModel>();
        Container.RegisterSingleton<AddHomeTaskViewModel>();

        Container.Verify();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        Register();

        MainWindow window = new();

        window.DataContext = Container.GetInstance<MainWindowViewModel>();

        window.ShowDialog();

    }
}
