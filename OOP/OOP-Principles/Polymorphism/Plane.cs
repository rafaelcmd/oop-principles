using OOP.OOP_Principles.Inheritance;

namespace OOP.OOP_Principles.Polymorphism;

public class Plane : Vehicle
{
    public int NumberOfDoors { get; set; }
    
    public override void Start()
    {
        Console.WriteLine("Starting the plane...");
    }
    
    public override void Stop()
    {
        Console.WriteLine("Stopping the plane...");
    }
}