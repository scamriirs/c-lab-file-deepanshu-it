// 16. Concept of three variables: temp, pressure and water level for a chemical industry boiler from the
keyboard. Throw an event called alert, if these variables level shoot above a certain level. [Event Handling]

using System;

class BoilerMonitor
{
    public event Action<string> Alert;

    public void CheckLevels(double temp, double pressure, double waterLevel)
    {
        if (temp > 100 || pressure > 50 || waterLevel > 10)
            Alert?.Invoke("Warning: One of the parameters exceeded the limit!");
    }
}

class Program
{
    static void Main()
    {
        BoilerMonitor monitor = new BoilerMonitor();
        monitor.Alert += message => Console.WriteLine(message);

        Console.WriteLine("Enter Temperature, Pressure, Water Level:");
        double temp = double.Parse(Console.ReadLine());
        double pressure = double.Parse(Console.ReadLine());
        double waterLevel = double.Parse(Console.ReadLine());

        monitor.CheckLevels(temp, pressure, waterLevel);
    }
}
