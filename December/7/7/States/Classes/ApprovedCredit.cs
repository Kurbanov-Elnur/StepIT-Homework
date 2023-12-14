using _7.Model.Classes;
using _7.States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.States.Classes;

class ApprovedCredit : IState
{
    public void Process(Credit credit)
    {
        Console.WriteLine($"The loan application has been approved. Here's your money {credit.Amount}");
    }
}
