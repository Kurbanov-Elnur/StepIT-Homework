using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Components;

class Motherboard(HardwareInfo hardwareInfo, string socketType, int maxMemorySlots, int usbPorts, bool supportsRAID)
{
    public HardwareInfo HardwareInfo { get; set; } = hardwareInfo.Clone() as HardwareInfo;
    public string SocketType { get; set; } = socketType;
    public int MaxMemorySlots { get; set; } = maxMemorySlots;
    public int USBPorts { get; set; } = usbPorts;
    public bool SupportsRAID { get; set; } = supportsRAID;

    public override string ToString()
    {
        return $"Motherboard: {HardwareInfo} \n" +
               $"Socket Type: {SocketType} \n" +
               $"Max Memory Slots: {MaxMemorySlots} \n" +
               $"USB Ports: {USBPorts} \n" +
               $"Supports RAID: {SupportsRAID} \n";
    }
}