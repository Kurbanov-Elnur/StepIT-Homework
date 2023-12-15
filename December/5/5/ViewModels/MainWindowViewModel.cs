using _5.Messages;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ViewModels;

class MainWindowViewModel : ViewModelBase
{
    private readonly IMessenger _messenger;
    private ViewModelBase currentView;

    public ViewModelBase CurrentView
    {
        get => currentView;
        set
        {
            Set(ref currentView, value);
        }
    }

    public MainWindowViewModel(IMessenger messenger)
    {
        _messenger = messenger;
        CurrentView = App.Container.GetInstance<AllTasksViewModel>();

        _messenger.Register<NavigationMessage>(this, message =>
        {
            CurrentView = message.ViewModelType;
        });
    }
}