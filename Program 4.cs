//Q4 Write programs to understand the use of library functions.

using System;

class MathFunctionsDemo
{
    static void Main()
    {
        double num1 = 16.5, num2 = -5.7;

        Console.WriteLine($"Ceiling of {num1}: {Math.Ceiling(num1)}");
        Console.WriteLine($"Floor of {num1}: {Math.Floor(num1)}");
        Console.WriteLine($"Absolute value of {num2}: {Math.Abs(num2)}");
        Console.WriteLine($"Square root of 25: {Math.Sqrt(25)}");
        Console.WriteLine($"Power (2^3): {Math.Pow(2, 3)}");
        Console.WriteLine($"Maximum of {num1} and {num2}: {Math.Max(num1, num2)}");
        Console.WriteLine($"Minimum of {num1} and {num2}: {Math.Min(num1, num2)}");
        Console.WriteLine($"Trigonometric Sin(30°): {Math.Sin(30 * Math.PI / 180)}");
    }
}







