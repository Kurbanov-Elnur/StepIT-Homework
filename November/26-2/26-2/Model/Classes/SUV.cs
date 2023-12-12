using _26_2.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_2.Model.Classes;

class SUV : IAutomobile
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string Engine { get; set; }
    public DateTime YearOfRelease { get; set; }
    public bool AllWheelDrive { get; set; }
    public int SeatingCapacity { get; set; }
}