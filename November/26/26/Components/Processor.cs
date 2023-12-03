using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Components;

class Processor(HardwareInfo hardwareInfo, int cores, double clockSpeedGHz, string architecture, bool hyperthreading)
{
    public HardwareInfo HardwareInfo { get; set; } = hardwareInfo.Clone() as HardwareInfo;
    public int Cores { get; set; } = cores;
    public double ClockSpeedGHz { get; set; } = clockSpeedGHz;
    public string Architecture { get; set; } = architecture;
    public bool Hyperthreading { get; set; } = hyperthreading;

    public override string ToString()
    {
        return $"Processor: {HardwareInfo} \n" +
               $"Cores: {Cores} \n" +
               $"Clock Speed: {ClockSpeedGHz}GHz \n" +
               $"Architecture: {Architecture} \n" +
               $"Hyperthreading: {Hyperthreading} \n";
    }
}