using _26_2.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_2.Model.Interfaces;

interface IAutomobile
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string Engine { get; set; }
    public DateTime YearOfRelease { get; set; }

    static public object[] BaseDataInput()
    {
        Console.WriteLine("Enter make: ");
        string? make = Console.ReadLine() ?? throw new InputException("Wrong input!");

        Console.WriteLine("Enter model: ");
        string? model = Console.ReadLine() ?? throw new InputException("Wrong input!");

        Console.WriteLine("Enter engine: ");
        string? engine = Console.ReadLine() ?? throw new InputException("Wrong input!");

        Console.WriteLine("Enter year of release: ");
        string? userInput = Console.ReadLine() ?? throw new InputException("Wrong input!");

        return new object[] 
        {
            make,
            model,
            engine,
            userInput
        };
    }
}