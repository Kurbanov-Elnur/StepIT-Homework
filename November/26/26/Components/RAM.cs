using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Components;

class RAM (string model, string manufacturer, int capacityGB, int speedMHz, string type)
{
    public string Model { get; set; } = model;
    public string Manufacturer { get; set; } = manufacturer;
    public int CapacityGB { get; set; } = capacityGB;
    public int SpeedMHz { get; set; } = speedMHz;
    public string Type { get; set; } = type;

    public override string ToString()
    {
        return $"RAM: {Manufacturer} {Model} \n" +
            $"Capacity: {CapacityGB}GB \n" +
            $"Speed: {SpeedMHz}MHz \n" +
            $"Type: {Type} \n";
    }
}