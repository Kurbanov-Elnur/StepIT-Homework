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

    public void SetBrandAndModel(string brand, string model)
    {
        Computer.Brand = brand;
        Computer.Model = model;
        Computer.Type = "Design computer";
    }

    public void SetGraphicsCard(string model, string manufacturer, int vramGB, int cudaCores)
    {
        Computer.GraphicsCard = new GraphicsCard(model, manufacturer, vramGB, cudaCores);
    }

    public void SetMotherboard(string model, string manufacturer, string socketType, int maxMemorySlots, int usbPorts)
    {
        Computer.Motherboard = new Motherboard(model, manufacturer, socketType, maxMemorySlots, usbPorts);
    }

    public void SetProcessor(string model, string manufacturer, int cores, double clockSpeedGHz, string architecture)
    {
        Computer.Processor = new Processor(model, manufacturer, cores, clockSpeedGHz, architecture);
    }

    public void SetRAM(string model, string manufacturer, int capacityGB, int speedMHz, string type)
    {
        Computer.RAM = new RAM(model, manufacturer, capacityGB, speedMHz, type);
    }

    public Computer GetComputer()
    {
        return Computer;
    }
}