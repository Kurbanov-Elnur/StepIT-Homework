using _5.Tasks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Tasks.Classes;

class HomeTask(string description, DateTime deadLine, string room, bool isHousekeeping, string responsiblePerson) : ITask
{
    public string Description { get; set; } = description;
    public DateTime DeadLine { get; set; } = deadLine;
    public bool IsCompleted { get; set; } = false;
    public string Room { get; set; } = room;
    public bool IsHousekeeping { get; set; } = isHousekeeping;
    public string ResponsiblePerson { get; set; } = responsiblePerson;
};