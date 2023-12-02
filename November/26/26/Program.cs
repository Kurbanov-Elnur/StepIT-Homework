using _26.Entities;
using _26.Services.Builders;
using _26.Services.Classes;


Director Director = new Director(new DesignerComputerBuilder());

Computer DesignComputer = Director.BuildComputer();

Console.WriteLine(DesignComputer);

Director.ComputerBuilder = new GamingComputerBuilder();

Computer GamingComputer = Director.BuildComputer();

Console.WriteLine(GamingComputer);

Director.ComputerBuilder = new OfficeComputerBuilder();

Computer OfficeComputer = Director.BuildComputer();

Console.WriteLine(OfficeComputer);