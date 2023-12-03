using _26.Entities;
using _26.Services.Builders;
using _26.Services.Classes;


Director Director = new Director(new DesignerComputerBuilder());

Computer DesignComputer = Director.BuildDesignComputer();

Console.WriteLine(DesignComputer);

Director.ComputerBuilder = new GamingComputerBuilder();

Computer GamingComputer = Director.BuildGamingComputer();

Console.WriteLine(GamingComputer);

Director.ComputerBuilder = new OfficeComputerBuilder();

Computer OfficeComputer = Director.BuildOfficeComputer();

Console.WriteLine(OfficeComputer);

//Если вызвать не стем строителем выйдет ошибка

try
{
    Director.ComputerBuilder = new GamingComputerBuilder();

    Computer OfficeComputer2 = Director.BuildOfficeComputer();

    Console.WriteLine(OfficeComputer);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}