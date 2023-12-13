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

class SUVFabric : IAutomobileFabric
{
    public IAutomobile CreateAutomobile()
    {
        return DataInput();
    }

    private SUV DataInput()
    {
        object[] data = IAutomobile.BaseDataInput();

        Console.Write("Enter all wheel drive (true/false): ");
        string input = Console.ReadLine();

        if (bool.TryParse(input, out bool result))
        {
            Console.WriteLine("Enter seating capacity: ");
            if (int.TryParse(Console.ReadLine(), out int seatingCapacity))
            {
                return new SUV(data[0] as string, data[1] as string, data[2] as string, DateTime.Parse(data[3] as string), result, seatingCapacity);
            }
        }
        
        throw new InputException("Wrong input!");
    }
}