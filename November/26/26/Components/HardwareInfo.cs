using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Components;

public class HardwareInfo(string model, string manufacturer) : ICloneable
{
    public string Model { get; set; } = model;
    public string Manufacturer { get; set; } = manufacturer;

    public object Clone()
    {
        return new HardwareInfo(Model, Manufacturer);
    }

    public override string ToString()
    {
        return $" {Model} {Manufacturer} ";
    }
}