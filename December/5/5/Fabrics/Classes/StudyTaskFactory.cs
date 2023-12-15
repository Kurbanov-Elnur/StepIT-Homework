using _5.Fabrics.Interfaces;
using _5.Tasks.Classes;
using _5.Tasks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Fabrics.Classes;

class StudyTaskFactory : ITaskFabric
{
    public ITask CreateTask()
    { 
        Console.WriteLine("Enter task description:");
        string description = Console.ReadLine();

        Console.WriteLine("Enter subject:");
        string subject = Console.ReadLine();

        Console.WriteLine("Enter professor:");
        string professor = Console.ReadLine();

        Console.WriteLine("Enter pages to read (integer):");
        int pagesToRead;
        if (!int.TryParse(Console.ReadLine(), out pagesToRead))
        {
            Console.WriteLine("Invalid pages input. Setting default value.");
            pagesToRead = 10;
        }

        Console.WriteLine("Enter deadline (dd-MM-yyyy):");
        DateTime deadline;
        if (!DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out deadline))
        {
            Console.WriteLine("Invalid deadline format. Setting default value.");
            deadline = DateTime.Now.AddDays(1);
        }

        return new StudyTask(description, deadline, subject, professor, pagesToRead);
    }
}