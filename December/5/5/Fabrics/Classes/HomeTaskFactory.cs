using _5.Fabrics.Interfaces;
using _5.Tasks.Classes;
using _5.Tasks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Fabrics.Classes;

class HomeTaskFactory : ITaskFabric
{
    public ITask CreateTask()
    {
        Console.WriteLine("Enter task description:");
        string description = Console.ReadLine();

        Console.WriteLine("Enter room:");
        string room = Console.ReadLine();

        Console.WriteLine("Is it a housekeeping task? (true/false):");
        bool isHousekeeping;
        if (!bool.TryParse(Console.ReadLine(), out isHousekeeping))
        {
            Console.WriteLine("Invalid input. Setting default value.");
            isHousekeeping = false;
        }

        Console.WriteLine("Enter responsible person:");
        string responsiblePerson = Console.ReadLine();

        Console.WriteLine("Enter deadline (dd-MM-yyyy):");
        DateTime deadline;
        if (!DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out deadline))
        {
            Console.WriteLine("Invalid deadline format. Setting default value.");
            deadline = DateTime.Now.AddDays(1);
        }

        return new HomeTask(description, deadline, room, isHousekeeping, responsiblePerson);
    }
}