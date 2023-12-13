using _26_2.Exceptions;
using _26_2.Fabrics.Interfaces;
using _26_2.Model.Classes;
using _26_2.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_2.Fabrics.Classes;

class TruckFabric : IAutomobileFabric
{
    public IAutomobile CreateAutomobile()
    {
        return DataInput();
    }

    private Truck DataInput()
    {
        object[] data = IAutomobile.BaseDataInput();

        Console.Write("Enter  extended cab (true/false): ");
        string input = Console.ReadLine();

        if (bool.TryParse(input, out bool result))
        {
            Console.WriteLine("Enter payload capacity: ");
            if (int.TryParse(Console.ReadLine(), out int payloadCapacity))
            {
                return new Truck(data[0] as string, data[1] as string, data[2] as string, DateTime.Parse(data[3] as string), payloadCapacity, result);
            }
        }

        throw new InputException("Wrong input!");
    }
}