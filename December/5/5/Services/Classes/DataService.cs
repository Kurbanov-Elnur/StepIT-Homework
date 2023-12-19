using _5.Messages;
using _5.Services.Interfaces;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Services.Classes;

class DataService : IDataService
{
    private readonly IMessenger _messenger;

    public DataService(IMessenger messenger)
    {
        _messenger = messenger;
    }

    public void SendData(object[] data)
    {
        _messenger.Send(new DatasMessage()
        {
            Datas = data
        });
    }

    public void SendData(object data)
    {
        _messenger.Send(new DataMessage()
        {
            Data = data
        });
    }
}