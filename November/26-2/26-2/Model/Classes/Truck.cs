using _26_2.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_2.Model.Classes;

class Truck(string make, string model, string engine, DateTime yearOfRelease, int payloadCapacity, bool extendedCab) : IAutomobile
{
    public string Make { get; set; } = make;
    public string Model { get; set; } = model;
    public string Engine { get; set; } = engine;
    public DateTime YearOfRelease { get; set; } = yearOfRelease;
    public int PayloadCapacity { get; set; } = payloadCapacity;
    public bool ExtendedCab { get; set; } = extendedCab;
}