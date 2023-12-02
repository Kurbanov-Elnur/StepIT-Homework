using _26.Components;
using _26.Entities;
using _26.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _26.Services.Classes;

class Director
{
    public IComputerBuilder ComputerBuilder { get; set; }

    public Director(IComputerBuilder computerBuilder)
    {
        ComputerBuilder = computerBuilder;
    }

    public Computer BuildComputer()
    {
        ComputerBuilder.SetBrandAndModel("XYZ", "XYZ-1000");
        ComputerBuilder.SetMotherboard("XYZ-Board", "XYZ Manufacturer", "XYZ Socket", 4, 6);
        ComputerBuilder.SetProcessor("XYZ Processor", "XYZ Manufacturer", 8, 4.0, "XYZ Architecture");
        ComputerBuilder.SetGraphicsCard("XYZ Graphics", "XYZ Graphics Manufacturer", 8, 2048);
        ComputerBuilder.SetRAM("XYZ RAM", "XYZ RAM Manufacturer", 16, 3200, "DDR4");

        return ComputerBuilder.Computer;
    }
}