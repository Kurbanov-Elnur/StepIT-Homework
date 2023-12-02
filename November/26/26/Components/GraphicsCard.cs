using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _26.Components;

public class GraphicsCard (string model, string manufacturer, int vramGB, int cudaCores)
{
    public string Model { get; set; } = model;
    public string Manufacturer { get; set; } = manufacturer;
    public int VRAMGB { get; set; } = vramGB;
    public int CUDACores { get; set; } = cudaCores;

    public override string ToString()
    {
        return $"Graphics Card: {Manufacturer} {Model} \n" +
            $"VRAM GB: {VRAMGB} \n" +
            $"CUDA Cores: {CUDACores} \n";
    }
}