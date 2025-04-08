// 15. Implement the concept of file handling to read XML file and display all the values in a read only Form. 


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
