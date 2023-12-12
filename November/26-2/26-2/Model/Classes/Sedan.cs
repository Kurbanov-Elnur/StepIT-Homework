using _26_2.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_2.Model.Classes;

class Sedan (string make, string model, string Engine, DateTime yearOfRelease, int trunkCapacity) : IAutomobile
{
    public string Make { get; set; } = make;
    public string Model { get; set; } = model;
    public string Engine { get; set; } = Engine;
    public DateTime YearOfRelease { get; set; } = yearOfRelease;
    public int TrunkCapacity { get; set; } = trunkCapacity;
}