//

using System;
using System.IO;

class MetricConverter
{
    public static void ConvertAndSave()
    {
        Console.Write("Enter value in meters: ");
        double meters = double.Parse(Console.ReadLine());

        double feet = meters * 3.28084;
        double inches = meters * 39.3701;

        File.WriteAllText("feet.txt", $"Meters: {meters}, Feet: {feet}, Inches: {inches}");
        Console.WriteLine("Data saved to feet.txt");
    }

    static void Main()
    {
        ConvertAndSave();
    }
}
