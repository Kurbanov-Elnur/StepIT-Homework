using _7.Model.Interfaces;
using _7.States.Classes;
using _7.States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _7.Model.Classes;

class Credit : ICredit
{
    public int Amount { get; set; }
    public IState State { get; set; }

    public Credit(int amount)
    {
        Amount = amount;
        State = new NewCreditState();
    }
}