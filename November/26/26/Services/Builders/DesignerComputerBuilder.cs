using _26.Components;
using _26.Components;
using _26.Entities;
using _26.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Services.Builders;

class DesignerComputerBuilder : IComputerBuilder
{
    public Computer Computer { get; set; }

    public DesignerComputerBuilder()
    {
        Computer = new();
    }

    public void SetHardwareInfo(HardwareInfo hardwareInfo)
    {
        Computer.HardwareInfo = hardwareInfo.Clone() as HardwareInfo;
        Computer.Type = "Design computer";
    }

    public void SetGraphicsCard(HardwareInfo hardwareInfo, int vramGB, int cudaCores, string gddrType)
    {
        Computer.GraphicsCards.Add(new GraphicsCard(hardwareInfo, vramGB, cudaCores, gddrType));
    }

    public void SetMotherboard(HardwareInfo hardwareInfo, string socketType, int maxMemorySlots, int usbPorts, bool supportsRAID)
    {
        Computer.Motherboard = new Motherboard(hardwareInfo, socketType, maxMemorySlots, usbPorts, supportsRAID);
    }

    public void SetProcessor(HardwareInfo hardwareInfo, int cores, double clockSpeedGHz, string architecture, bool hyperthreading)
    {
        Computer.Processor = new Processor(hardwareInfo, cores, clockSpeedGHz, architecture, hyperthreading);
    }

    public void SetRAM(HardwareInfo hardwareInfo, int capacityGB, int speedMHz, string type, int modules)
    {
        Computer.RAMs.Add(new RAM(hardwareInfo, capacityGB, speedMHz, type, modules));
    }

    public Computer GetComputer()
    {
        return Computer;
    }
}