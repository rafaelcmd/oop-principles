using OOP.OOP_Principles.Inheritance;

namespace OOP.OOP_Principles.Polymorphism;

public class Motorcycle : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Starting the motorcycle...");
    }
    
    public override void Stop()
    {
        Console.WriteLine("Stopping the motorcycle...");
    }
}