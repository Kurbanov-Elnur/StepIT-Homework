using _5.Fabrics.Interfaces;
using _5.Messages;
using _5.Tasks.Classes;
using _5.Tasks.Interfaces;
using GalaSoft.MvvmLight.Messaging;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Fabrics.Classes;

class HomeTaskFactory : ITaskFabric
{
    private readonly IMessenger _messenger;

    string description, room, responsiblePerson;
    DateTime deadline;
    bool isHousekeeping;  

    public HomeTaskFactory(IMessenger messenger)
    {
        _messenger = messenger;

        _messenger.Register<DatasMessage>(this, message =>
        {
            description = message.Datas[0].ToString();
            deadline = DateTime.Parse(message.Datas[1].ToString());
            room = message.Datas[2].ToString();
            isHousekeeping = bool.Parse(message.Datas[3].ToString());
            responsiblePerson = message.Datas[4].ToString();
        });
    }

    public ITask CreateTask()
    {
        return new HomeTask(description, deadline, room, isHousekeeping, responsiblePerson);
    }
}