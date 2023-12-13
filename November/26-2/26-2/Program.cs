using _26_2.Fabrics.Classes;
using _26_2.Fabrics.Interfaces;
using _26_2.Model.Classes;
using _26_2.Model.Interfaces;

IAutomobileFabric Fabric = new SedanFabric();

IAutomobile sedan = Fabric.CreateAutomobile();

Fabric = new SUVFabric();

IAutomobile suv = Fabric.CreateAutomobile();

Fabric = new TruckFabric();

IAutomobile truck = Fabric.CreateAutomobile();