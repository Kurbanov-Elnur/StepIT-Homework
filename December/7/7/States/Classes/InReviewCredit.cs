using _7.Model.Classes;
using _7.States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.States.Classes;

class InReviewCredit : IState
{
    public void Process(Credit credit)
    {
        Console.WriteLine("The loan application is under consideration.");

        Console.WriteLine(
            "Will the application be rejected or approved? \n" + 
            "1. Rejected\n" + 
            "2. Approved");

        Int32.TryParse(Console.ReadLine(), out int choice);

        switch (choice)
        {
            case 1:
                credit.State = new DeniedCredit();
                break;
            case 2:
                credit.State = new ApprovedCredit();
                break;
            default:
                throw new ArgumentException("Wrong input!");
        }
    }
}