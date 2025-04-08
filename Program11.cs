// Write a program to implement class and its objects

using System;

class Student
{
    public string Name;
    public int Age;

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student();
        student1.Name = "Akash";
        student1.Age = 21;
        student1.Display();
    }
}
