using _28.Dishes.AbstractClass;
using _28.Dishes.Interfaces;
using _28.Fabrics.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _28.Fabrics.Classes;

class GeorgianRestaurantFabric : RestaurantFactory
{
    public void Menu()
    {
        var assembly = Assembly.GetExecutingAssembly();

        List<Type> types = assembly.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(GEO))).ToList();

        int i = 1;

        foreach (var type in types)
        {
            Console.WriteLine($"{i}. {type.Name}");
            i++;
        }

        Console.WriteLine("Enter dish name:\n");

        int selection = Int32.Parse(Console.ReadLine());

        Cook(Activator.CreateInstance(types[selection - 1]) as IDish);
    }

    public IDish Cook(IDish dish)
    {
        if (dish as GEO == null)
            throw new ArgumentException();

        dish.Cook();

        return dish;
    }

    public void Service(IDish dish)
    {
        if (dish as GEO == null)
            throw new ArgumentException();

        dish.Cook();
    }
}