using _3.Others.Classes;
using _3.RestaurantStaff.Classes;
using _3.RestaurantStaff.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Proxy;

class ChiefProxy 
{
    private Chief Chief { get; set; }

    public ChiefProxy(Chief chief)
    {
        Chief = chief;
    }

    public void GetStatus()
    {
        Chief.GetStatus();
    }
}