public class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
        var r=1;
    }
    public void Start()
    {
        Console.WriteLine("Vehicle is starting...");
        // Logic to start the vehicle
    }

    public void Stop()
    {
        Console.WriteLine("Vehicle is stopping...");
        // Logic to stop the vehicle
    }
}