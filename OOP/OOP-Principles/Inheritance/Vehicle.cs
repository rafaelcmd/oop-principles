namespace OOP.OOP_Principles.Inheritance;

public class Vehicle
{
    public string Brand { get; set; }
    
    public string Model { get; set; }
    
    public int Year { get; set; }
    
    public virtual void Start()
    {
        Console.WriteLine("Starting the vehicle...");
    }
    
    public virtual void Stop()
    {
        Console.WriteLine("Stopping the vehicle...");
    }
}