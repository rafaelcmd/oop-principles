namespace OOP.OOP_Principles.Inheritance;

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
    
    public override void Start()
    {
        Console.WriteLine("Starting the car...");
    }
    
    public override void Stop()
    {
        Console.WriteLine("Stopping the car...");
    }
}