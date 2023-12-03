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

    public void SetHardwareInfo(HardwareInfo hardwareInfo);
    public void SetGraphicsCard(HardwareInfo hardwareInfo, int vramGB, int cudaCores, string gddrType);
    public void SetMotherboard(HardwareInfo hardwareInfo, string socketType, int maxMemorySlots, int usbPorts, bool supportsRAID);
    public void SetProcessor(HardwareInfo hardwareInfo, int cores, double clockSpeedGHz, string architecture, bool hyperthreading);
    public void SetRAM(HardwareInfo hardwareInfo, int capacityGB, int speedMHz, string type, int modules);
    public Computer GetComputer();
}