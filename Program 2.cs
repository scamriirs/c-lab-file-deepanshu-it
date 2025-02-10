//Q2 Write program to show the use of various data types available in C#

using System;
class DataTypeDemo
{
    static void Main(string[] args)
    {
        Console.WriteLine("C# Data Types Demonstration");
        // Integer type
        int myInt = 42;
        Console.WriteLine($"Integer (int): {myInt}");
        // Floating-point type
        float myFloat = 3.14f;
        Console.WriteLine($"Floating-point (float): {myFloat}");
        // Double type
        double myDouble = 2.7182818284;
        Console.WriteLine($"Double (double): {myDouble}");
        // Character type
        char myChar = 'A';
        Console.WriteLine($"Character (char): {myChar}");
        // String type
        string myString = "Hello, C#!";
        Console.WriteLine($"String (string): {myString}");
        // Boolean type
        bool myBool = true;
        Console.WriteLine($"Boolean (bool): {myBool}");
        // Byte type
        byte myByte = 255;
        Console.WriteLine($"Byte (byte): {myByte}");
        // Short type
        short myShort = -32768;
        Console.WriteLine($"Short (short): {myShort}");
        // Long type
        long myLong = 9223372036854775807L;
        Console.WriteLine($"Long (long): {myLong}");
        // Decimal type
        decimal myDecimal = 79228162514264337593543950335M;
        Console.WriteLine($"Decimal (decimal): {myDecimal}");
        // Unsigned integer type
        uint myUInt = 4294967295;
        Console.WriteLine($"Unsigned Integer (uint): {myUInt}");
        // Unsigned long type
        ulong myULong = 18446744073709551615UL;
        Console.WriteLine($"Unsigned Long (ulong): {myULong}");
        // Object type
        object myObject = "I can hold any type!";
        Console.WriteLine($"Object (object): {myObject}");
        // Nullable type
        int? myNullableInt = null;
        Console.WriteLine($"Nullable Integer (int?): {myNullableInt}");
        // Dynamic type
        dynamic myDynamic = 42;
        Console.WriteLine($"Dynamic (dynamic): {myDynamic}");
        myDynamic = "Now I'm a string!";
        Console.WriteLine($"Dynamic reassigned: {myDynamic}");
        // Array type
        int[] myArray = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Array (int[]): {string.Join(", ", myArray)}");
    }
}


