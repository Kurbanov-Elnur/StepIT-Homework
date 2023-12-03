using _26.Components;
using _26.Entities;
using _26.Services.Builders;
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

    public Computer BuildDesignComputer()
    {
        if (ComputerBuilder as DesignerComputerBuilder == null)
            throw new InvalidOperationException("The wrong builder");

        ComputerBuilder.SetHardwareInfo(new HardwareInfo("ThinkCentre XYZ", "Lenovo"));
        ComputerBuilder.SetMotherboard(new HardwareInfo("Lenovo XYZ-Board", "Lenovo"), "XYZ Socket", 4, 6, false);
        ComputerBuilder.SetProcessor(new HardwareInfo("Intel Core i7-XYZ", "Intel"), 8, 4.0, "XYZ Architecture", false);
        ComputerBuilder.SetGraphicsCard(new HardwareInfo("NVIDIA XYZ Graphics", "NVIDIA"), 8, 2048, "GDDR5X");
        ComputerBuilder.SetGraphicsCard(new HardwareInfo("AMD XYZ Graphics", "AMD"), 6, 1028, "GDDR5X");
        ComputerBuilder.SetRAM(new HardwareInfo("Lenovo XYZ RAM", "Lenovo"), 16, 3200, "DDR4", 3);

        return ComputerBuilder.Computer;
    }

    public Computer BuildGamingComputer()
    {
        if (ComputerBuilder as GamingComputerBuilder == null)
            throw new InvalidOperationException("The wrong builder");

        ComputerBuilder.SetHardwareInfo(new HardwareInfo("ThinkCentre XYZ", "Lenovo"));
        ComputerBuilder.SetMotherboard(new HardwareInfo("Lenovo XYZ-Board", "Lenovo"), "XYZ Socket", 4, 6, false);
        ComputerBuilder.SetProcessor(new HardwareInfo("Intel Core i7-XYZ", "Intel"), 8, 4.0, "XYZ Architecture", false);

        ComputerBuilder.SetGraphicsCard(new HardwareInfo("NVIDIA XYZ Graphics", "NVIDIA"), 8, 2048, "GDDR5X");
        ComputerBuilder.SetGraphicsCard(new HardwareInfo("AMD XYZ Graphics", "AMD"), 6, 1028, "GDDR5X");

        ComputerBuilder.SetRAM(new HardwareInfo("Lenovo XYZ RAM", "Lenovo"), 16, 3200, "DDR4", 3);
        ComputerBuilder.SetRAM(new HardwareInfo("Lenovo XYZ RAM", "Lenovo"), 16, 3200, "DDR4", 3);
        ComputerBuilder.SetRAM(new HardwareInfo("Lenovo XYZ RAM", "Lenovo"), 16, 3200, "DDR4", 3);
        ComputerBuilder.SetRAM(new HardwareInfo("Lenovo XYZ RAM", "Lenovo"), 16, 3200, "DDR4", 3);

        return ComputerBuilder.Computer;
    }

    public Computer BuildOfficeComputer()
    {
        if (ComputerBuilder as OfficeComputerBuilder == null)
            throw new InvalidOperationException("The wrong builder");

        ComputerBuilder.SetHardwareInfo(new HardwareInfo("ThinkCentre XYZ", "Lenovo"));
        ComputerBuilder.SetMotherboard(new HardwareInfo("Lenovo XYZ-Board", "Lenovo"), "XYZ Socket", 4, 6, false);
        ComputerBuilder.SetProcessor(new HardwareInfo("Intel Core i7-XYZ", "Intel"), 8, 4.0, "XYZ Architecture", false);
        ComputerBuilder.SetGraphicsCard(new HardwareInfo("NVIDIA XYZ Graphics", "NVIDIA"), 8, 2048, "GDDR5X");
        ComputerBuilder.SetRAM(new HardwareInfo("Lenovo XYZ RAM", "Lenovo"), 16, 3200, "DDR4", 3);

        return ComputerBuilder.Computer;
    }
}