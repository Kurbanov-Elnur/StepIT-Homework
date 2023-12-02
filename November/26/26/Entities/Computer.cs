using _26.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Entities;

class Computer
{
    public string Brand { get; set; } 
    public string Model { get; set; } 
    public string Type { get; set; } 
    public Motherboard Motherboard { get; set; } 
    public Processor Processor { get; set; }
    public GraphicsCard GraphicsCard { get; set; }
    public RAM RAM { get; set; }

    public Computer(string brand, string model, string type, Motherboard motherboard, Processor processor, GraphicsCard graphicsCard, RAM rAM)
    {
        Brand = brand;
        Model = model;
        Type = type;
        Motherboard = motherboard;
        Processor = processor;
        GraphicsCard = graphicsCard;
        RAM = rAM;
    }

    public Computer() { }

    public override string ToString()
    {
        return $"Computer: {Brand} {Model} \n" +
            $"Computer type: {Type} \n" +
            $"Motherboard data: \n{Motherboard}" +
            $"Processor data: \n{Processor}" +
            $"GraphicsCard data: \n{GraphicsCard}" +
            $"RAM data: \n{RAM}";
    }
}