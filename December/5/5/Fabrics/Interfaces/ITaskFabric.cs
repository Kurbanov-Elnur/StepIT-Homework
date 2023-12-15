using _5.Tasks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Fabrics.Interfaces;

interface ITaskFabric
{
    public ITask CreateTask();
}