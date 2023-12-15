using _5.Fabrics.Interfaces;
using _5.Tasks.Classes;
using _5.Tasks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Fabrics.Classes;

class PersonalTaskFactory : ITaskFabric
{
    public ITask CreateTask()
    {
        Console.WriteLine("Enter task description:");
        string description = Console.ReadLine();

        Console.WriteLine("Enter category:");
        string category = Console.ReadLine();

        Console.WriteLine("Is it a hobby task? (true/false):");
        bool isHobby;
        if (!bool.TryParse(Console.ReadLine(), out isHobby))
        {
            Console.WriteLine("Invalid input. Setting default value.");
            isHobby = false;
        }

        Console.WriteLine("Enter location:");
        string location = Console.ReadLine();

        Console.WriteLine("Enter deadline (dd-MM-yyyy):");
        DateTime deadline;
        if (!DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out deadline))
        {
            Console.WriteLine("Invalid deadline format. Setting default value.");
            deadline = DateTime.Now.AddDays(1);
        }

        return new PersonalTask(description, deadline, category, isHobby, location);
    }
}