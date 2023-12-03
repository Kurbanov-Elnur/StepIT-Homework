using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Components;

class GraphicsCard(HardwareInfo hardwareInfo, int vramGB, int cudaCores, string gddrType)
{
    public HardwareInfo HardwareInfo { get; set; } = hardwareInfo.Clone() as HardwareInfo;
    public int VRAMGB { get; set; } = vramGB;
    public int CUDACores { get; set; } = cudaCores;
    public string GDDRType { get; set; } = gddrType;

    public override string ToString()
    {
        return $"Graphics Card: {HardwareInfo} \n" +
               $"VRAM GB: {VRAMGB} \n" +
               $"CUDA Cores: {CUDACores} \n" +
               $"GDDR Type: {GDDRType} \n";
    }
}