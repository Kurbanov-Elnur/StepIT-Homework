using _7.Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.States.Interfaces;

interface IState
{
    void Process(Credit credit);
}