using _5.Tasks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Tasks.Classes;

class WorkTask(string description, DateTime deadLine, string project, int priority, string assignedTo) : ITask
{
    public string Description { get; set; } = description;
    public DateTime DeadLine { get; set; } = deadLine;
    public bool IsCompleted { get; set; } = false;
    public string Project { get; set; } = project;
    public int Priority { get; set; } = priority;
    public string AssignedTo { get; set; } = assignedTo;
};