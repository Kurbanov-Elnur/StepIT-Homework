
using _5.Messages;
using _5.Services.Interfaces;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;

namespace _5.Services.Classes;

class NavigationService : INavigationService
{
    private readonly IMessenger _messenger;
    public NavigationService(IMessenger messenger)
    {
        _messenger = messenger;
    }

    public void NavigateTo<T>() where T : ViewModelBase
    {
        _messenger.Send(new NavigationMessage()
        {
            ViewModelType = App.Container.GetInstance<T>()
        });
    }
}
