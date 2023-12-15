using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Tasks.Interfaces;

interface ITask
{
    public string Description { get; set; }
    public DateTime DeadLine { get; set; }
    public bool IsCompleted { get; set; } 

    public void Execute()
    {
        Console.WriteLine($"It needs to be done:\n {Description}");
    }
}