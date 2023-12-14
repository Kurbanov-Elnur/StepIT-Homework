using _3.Others.Classes;
using _3.RestaurantStaff.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.RestaurantStaff.Classes;

class Chief : IChief
{
    public List<Order> Orders { get; set; }

    public Chief()
    {
        Orders = new();
    }

    public void AddOrder(Order order)
    {
        Orders.Add(order);
    }

    public void DeleteOrder()
    {
        foreach (var order in Orders)
        {
            if (order.Status == Status.Done)
                Orders.Remove(order);
        }
    }

    public void EditStatus()
    {
        int i = 0;
        foreach (var order in Orders)
        {
            Console.WriteLine($"Order {i + 1}: {order.ID}");
            i++;
        }

        Int32.TryParse(Console.ReadLine(), out int selectedOrder);

        Console.WriteLine(
            "1. Done\n" +
            "2. Preparing\n" +
            "3. Refused\n");

        Int32.TryParse(Console.ReadLine(), out int selectedStatus);

        Orders[selectedOrder - 1].Status = (Status)Enum.Parse(typeof(Status), selectedStatus.ToString()); ;
    }

    public void GetStatus()
    {
        foreach (var order in Orders)
        {
            Console.WriteLine($"Order: {order.ID} | {order.Status}");
        }
    }
}