//18. Implement the concept in C# consisting of a delegate called student that refers to a method called
// student record (), your program should get the details of student record and display. [Delegate] 

using System;

delegate void StudentDelegate();

class Student
{
    public void DisplayRecord()
    {
        Console.WriteLine("Student Record: John Doe, Age: 21, Class: CS101");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();
        StudentDelegate del = new StudentDelegate(student.DisplayRecord);
        del();
    }
}
