using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Components;

public class Motherboard (string model, string manufacturer, string socketType, int maxMemorySlots, int usbPorts)
{
    public string Model { get; set; } = model;
    public string Manufacturer { get; set; } = manufacturer;
    public string SocketType { get; set; } = socketType;
    public int MaxMemorySlots { get; set; } = maxMemorySlots;
    public int USBPorts { get; set; } = usbPorts;

    public override string ToString()
    {
        return $"Motherboard: {Manufacturer} {Model} \n" +
            $"Socket Type: {SocketType} \n" +
            $"Max Memory Slots: {MaxMemorySlots} \n" +
            $"USB Ports: {USBPorts} \n";
    }
}