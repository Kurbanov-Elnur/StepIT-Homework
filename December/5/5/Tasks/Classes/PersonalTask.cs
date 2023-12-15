using _5.Tasks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Tasks.Classes;

class PersonalTask(string description, DateTime deadLine, string category, bool isHobby, string location) : ITask
{
    public string Description { get; set; } = description;
    public DateTime DeadLine { get; set; } = deadLine;
    public bool IsCompleted { get; set; } = false;
    public string Category { get; set; } = category;
    public bool IsHobby { get; set; } = isHobby;
    public string Location { get; set; } = location;
};