
public class VehicleRunner
{

    public VehicleRunner()
    {

    }

    public void Run()
    {
        Console.WriteLine("Welcome to the Vehicle Management System!");
        var vehicle1 = new Vehicle("Toyota", "Camry", 2020);
        var vehicle2 = new Vehicle("Honda", "Civic", 2019);
        var inputComand = string.Empty;
        var selectedVehicle = string.Empty;

        while (inputComand != "exit")
        {
            Console.WriteLine("Enter a command (start, stop, exit):");
            inputComand = Console.ReadLine();
            switch (inputComand)
            {
                case "start":
                    vehicle1.Start();
                    break;
                case "stop":
                    vehicle1.Stop();
                    break;
                case "exit":
                    Console.WriteLine("Exiting the program...");
                    break;
                default:
                    Console.WriteLine("Invalid command. Please try again.");
                    break;
            }
        }
    }
}