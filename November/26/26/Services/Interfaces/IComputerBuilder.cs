using _26.Components;
using _26.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _26.Services.Interfaces;

interface IComputerBuilder
{
    public Computer Computer { get; set; }

    public void SetBrandAndModel(string brand, string model);
    public void SetMotherboard(string model, string manufacturer, string socketType, int maxMemorySlots, int usbPorts);
    public void SetProcessor(string model, string manufacturer, int cores, double clockSpeedGHz, string architecture);
    public void SetGraphicsCard(string model, string manufacturer, int vramGB, int cudaCores);
    public void SetRAM(string model, string manufacturer, int capacityGB, int speedMHz, string type);
    public Computer GetComputer();
}