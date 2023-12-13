using _26_2.Model.Interfaces;

namespace _26_2.Model.Classes;

class SUV(string make, string model, string engine, DateTime yearOfRelease, bool allWheelDrive, int seatingCapacity)  : IAutomobile
{
    public string Make { get; set; } = make;
    public string Model { get; set; } = model;
    public string Engine { get; set; } = engine;
    public DateTime YearOfRelease { get; set; } = yearOfRelease;
    public bool AllWheelDrive { get; set; } = allWheelDrive;
    public int SeatingCapacity { get; set; } = seatingCapacity;
}