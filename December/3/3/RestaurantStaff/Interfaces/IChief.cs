using _3.Others.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.RestaurantStaff.Interfaces;

interface IChief
{
    public List<Order> Orders { get; set; }

    public void AddOrder(Order order);
    public void DeleteOrder();
    public void EditStatus();
    public void GetStatus();
}