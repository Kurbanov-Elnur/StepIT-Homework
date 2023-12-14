using _7.States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Model.Interfaces;

interface ICredit
{
    public int Amount { get; set; }
    public IState State { get; set; }
}