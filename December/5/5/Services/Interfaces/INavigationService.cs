using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Services.Interfaces;

interface INavigationService
{
    public void NavigateTo<T>() where T : ViewModelBase;
}
