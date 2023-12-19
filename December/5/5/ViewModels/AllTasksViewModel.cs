using _5.Services.Interfaces;
using _5.Tasks.Interfaces;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ViewModels;

class AllTasksViewModel : ViewModelBase
{
    private readonly INavigationService _navigationService;
    private readonly IDataService _dataService;

    public ObservableCollection<ITask> _tasks;

    public ObservableCollection<ITask> Tasks
    {
        get => _tasks;
        set
        {
            Set(ref _tasks, value);
        }
    }

    public AllTasksViewModel(INavigationService navigationService, IDataService dataService)
    {
        Tasks = new();
        _navigationService = navigationService;
        _dataService = dataService;
    }

    public RelayCommand AddCommand
    {
        get => new(() =>
        {
            _dataService.SendData(Tasks);
            _navigationService.NavigateTo<AddHomeTaskViewModel>();
        });
    }
}