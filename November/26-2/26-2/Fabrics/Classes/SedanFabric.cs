using _26_2.Exceptions;
using _26_2.Fabrics.Interfaces;
using _26_2.Model.Classes;
using _26_2.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace _26_2.Fabrics.Classes;

class SedanFabric : IAutomobileFabric
{ 
    public IAutomobile CreateAutomobile()
    {
        return DataInput();
    }

    private Sedan DataInput()
    {
        object[] data = IAutomobile.BaseDataInput();

        Console.WriteLine("Enter trunk capacity: ");
        if (int.TryParse(Console.ReadLine(), out int trunkCapacity))
        {
            return new Sedan(data[0] as string, data[1] as string, data[2] as string, DateTime.Parse(data[3] as string), trunkCapacity);
        }
        else
            throw new InputException("Wrong input!");
    }
}