using _7.Model.Classes;
using _7.States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _7.States.Classes;

class NewCreditState : IState
{
    public void Process(Credit credit)
    {
        Console.WriteLine("A new loan application. We are reviewing the documents.");
        credit.State = new InReviewCredit();
    }
}