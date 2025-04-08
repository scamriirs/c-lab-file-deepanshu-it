//

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
