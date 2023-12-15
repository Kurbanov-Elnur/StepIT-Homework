using _5.Fabrics.Interfaces;
using _5.Tasks.Classes;
using _5.Tasks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Fabrics.Classes;

class WorkTaskFabric : ITaskFabric
{
    public ITask CreateTask()
    {
        Console.WriteLine("Enter task description:");
        string description = Console.ReadLine();

        Console.WriteLine("Enter project:");
        string project = Console.ReadLine();

        Console.WriteLine("Enter priority (integer):");
        int priority;
        if (!int.TryParse(Console.ReadLine(), out priority))
        {
            Console.WriteLine("Invalid priority input. Setting default value.");
            priority = 1;
        }

        Console.WriteLine("Enter assigned person:");
        string assignedTo = Console.ReadLine();

        Console.WriteLine("Enter deadline (dd-MM-yyyy):");
        DateTime deadline;
        if (!DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out deadline))
        {
            Console.WriteLine("Invalid deadline format. Setting default value.");
            deadline = DateTime.Now.AddDays(1);
        }

        return new WorkTask(description, deadline, project, priority, assignedTo);
    }
}