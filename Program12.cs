// 12. Write a program to implement constructors.

using System;

class Student
{
    public string Name;
    public int Age;

    // Constructor
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student("Akash", 21);
        student1.Display();
    }
}
