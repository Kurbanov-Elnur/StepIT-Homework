using _5.Tasks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Tasks.Classes;

class StudyTask(string description, DateTime deadLine, string subject, string professor, int pagesToRead) : ITask
{
    public string Description { get; set; } = description;
    public DateTime DeadLine { get; set; } = deadLine;
    public bool IsCompleted { get; set; } = false;
    public string Subject { get; set; } = subject;
    public string Professor { get; set; } = professor;
    public int PagesToRead { get; set; } = pagesToRead;
};