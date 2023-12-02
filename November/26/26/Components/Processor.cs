using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Components;

class Processor (string model, string manufacturer, int cores, double clockSpeedGHz, string architecture)
{
    public string Model { get; set; } = model;
    public string Manufacturer { get; set; } = manufacturer;
    public int Cores { get; set; } = cores;
    public double ClockSpeedGHz { get; set; } = clockSpeedGHz;
    public string Architecture { get; set; } = architecture;

    public override string ToString()
    {
        return $"Processor: {Manufacturer} {Model} \n" +
            $"Cores: {Cores} \n" +
            $"Clock Speed: {ClockSpeedGHz}GHz \n" +
            $"Architecture: {Architecture} \n";
    }
}