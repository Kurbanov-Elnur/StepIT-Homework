using _5.Fabrics.Classes;
using _5.Messages;
using _5.Services.Classes;
using _5.Services.Interfaces;
using _5.Tasks.Interfaces;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _5.ViewModels;

class AddHomeTaskViewModel : ViewModelBase, INotifyPropertyChanged
{
    private readonly IDataService _dataService;
    private readonly INavigationService _navigationService;
    private readonly IMessenger _messenger;

    private HomeTaskFactory _homeTaskFactory;
    public ObservableCollection<ITask> _tasks;

    private string description;
    private DateTime deadLine = DateTime.Now;
    private string room;
    private string isHousekeeping;
    private string responsiblePerson;

    public string Description
    {
        get => description;
        set
        {
            if (description != value)
            {
                description = value;
                OnPropertyChanged(nameof(description));
            }
        }
    }

    public DateTime DeadLine
    {
        get => deadLine; 
        set
        {
            if (deadLine != value)
            {
                deadLine = value;
                OnPropertyChanged(nameof(deadLine));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public string Room
    {
        get => room;
        set
        {
            if (room != value)
            {
                room = value;
                OnPropertyChanged(nameof(room));
            }
        }
    }

    public string IsHousekeeping
    {
        get => isHousekeeping;
        set
        {
            if (isHousekeeping != value)
            {
                isHousekeeping = value;
                OnPropertyChanged(nameof(isHousekeeping));
            }
        }
    }

    public string ResponsiblePerson
    {
        get => responsiblePerson;
        set
        {
            if (responsiblePerson != value)
            {
                responsiblePerson = value;
                OnPropertyChanged(nameof(responsiblePerson));
            }
        }
    }

    public AddHomeTaskViewModel(IMessenger messenger, IDataService dataService, HomeTaskFactory homeTaskFactory, INavigationService navigationService)
    {
        _navigationService = navigationService;
        _dataService = dataService;
        _messenger = messenger;
        _homeTaskFactory = homeTaskFactory;

        _messenger.Register<DataMessage>(this, message =>
        {
            if (message.Data as ObservableCollection<ITask> != null)
                _tasks = message.Data as ObservableCollection<ITask>;
        });
        }

    public RelayCommand AddTask
    { 
        get => new (() =>
        {
            _dataService.SendData(new object[] { description, deadLine, room, isHousekeeping, responsiblePerson });

            _tasks.Add(_homeTaskFactory.CreateTask());
            _navigationService.NavigateTo<AllTasksViewModel>();
        });
    }
}