using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Components;

class RAM(HardwareInfo hardwareInfo, int capacityGB, int speedMHz, string type, int modules)
{
    public HardwareInfo HardwareInfo { get; set; } = hardwareInfo.Clone() as HardwareInfo;
    public int CapacityGB { get; set; } = capacityGB;
    public int SpeedMHz { get; set; } = speedMHz;
    public string Type { get; set; } = type;
    public int Modules { get; set; } = modules;

    public override string ToString()
    {
        return $"RAM: {HardwareInfo} \n" +
               $"Capacity: {CapacityGB}GB \n" +
               $"Speed: {SpeedMHz}MHz \n" +
               $"Type: {Type} \n" +
               $"Modules: {Modules} \n";
    }
}