//Q5 Write a program to demonstrate the use of various arithmetic, unary, logical, bit-wise, assignment and conditional operators.

using System;

class OperatorsDemo
{
    static void Main()
    {
        int a = 10, b = 5;

        // Arithmetic Operators
        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine($"Addition: {a} + {b} = {a + b}");
        Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
        Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
        Console.WriteLine($"Division: {a} / {b} = {a / b}");
        Console.WriteLine($"Modulus: {a} % {b} = {a % b}");
        Console.WriteLine();

        // Unary Operators
        Console.WriteLine("Unary Operators:");
        Console.WriteLine($"Post-Increment (a++): {a++} (Now a = {a})");
        Console.WriteLine($"Pre-Increment (++a): {++a} (Now a = {a})");
        Console.WriteLine($"Post-Decrement (b--): {b--} (Now b = {b})");
        Console.WriteLine($"Pre-Decrement (--b): {--b} (Now b = {b})");
        Console.WriteLine();

        // Logical Operators
        bool x = true, y = false;
        Console.WriteLine("Logical Operators:");
        Console.WriteLine($"AND (x && y): {x && y}");
        Console.WriteLine($"OR (x || y): {x || y}");
        Console.WriteLine($"NOT (!x): {!x}");
        Console.WriteLine();

        // Bitwise Operators
        int p = 5, q = 3; // 5 = 0101, 3 = 0011
        Console.WriteLine("Bitwise Operators:");
        Console.WriteLine($"Bitwise AND (p & q): {p & q}");  // 0101 & 0011 = 0001 (1)
        Console.WriteLine($"Bitwise OR (p | q): {p | q}");   // 0101 | 0011 = 0111 (7)
        Console.WriteLine($"Bitwise XOR (p ^ q): {p ^ q}");  // 0101 ^ 0011 = 0110 (6)
        Console.WriteLine($"Left Shift (p << 1): {p << 1}"); // 0101 << 1 = 1010 (10)
        Console.WriteLine($"Right Shift (p >> 1): {p >> 1}");// 0101 >> 1 = 0010 (2)
        Console.WriteLine();

        // Assignment Operators
        int num = 10;
        Console.WriteLine("Assignment Operators:");
        num += 5; Console.WriteLine($"num += 5 -> {num}");
        num -= 3; Console.WriteLine($"num -= 3 -> {num}");
        num *= 2; Console.WriteLine($"num *= 2 -> {num}");
        num /= 4; Console.WriteLine($"num /= 4 -> {num}");
        num %= 3; Console.WriteLine($"num %= 3 -> {num}");
        Console.WriteLine();

        // Conditional (Ternary) Operator
        int value1 = 10, value2 = 20;
        string result = (value1 > value2) ? "Value1 is greater" : "Value2 is greater";
        Console.WriteLine("Conditional (Ternary) Operator:");
        Console.WriteLine(result);
    }
}
