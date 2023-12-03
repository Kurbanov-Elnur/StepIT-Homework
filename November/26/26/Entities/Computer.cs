using _26.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Entities;

class Computer
{
    public HardwareInfo HardwareInfo { get; set; }
    public string Type { get; set; } 
    public Motherboard Motherboard { get; set; } 
    public Processor Processor { get; set; }
    public List<GraphicsCard> GraphicsCards { get; set; }
    public List<RAM> RAMs { get; set; }

    public Computer(HardwareInfo hardwareInfo, string type, Motherboard motherboard, Processor processor, List<GraphicsCard> graphicsCard, List<RAM> rAM)
    {
        HardwareInfo = hardwareInfo.Clone() as HardwareInfo;
        Type = type;
        Motherboard = motherboard;
        Processor = processor;
        GraphicsCards =graphicsCard;
        RAMs = rAM;
    }

    public Computer()
    {
        GraphicsCards = new();
        RAMs = new();
    }

    public override string ToString()
    {
        string graphicsCardsInfo = string.Join("\n", GraphicsCards.Select(card => card.ToString()));

        string ramInfo = string.Join("\n", RAMs.Select(ram => ram.ToString()));

        return $"Computer: {HardwareInfo} \n" +
               $"Computer type: {Type} \n" +
               $"{Motherboard}" +
               $"{Processor}" +
               $"{graphicsCardsInfo}" +
               $"{ramInfo}";
    }
}