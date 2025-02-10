// Q1 Write program to demonstrate the working of C# SDK

//C# syntax is designed to be clean and easy to read, and its structure is heavily influenced by C and Java. 
//Basic C# Program Example

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
/*
Line-by-Line Explanation
1.	using System : Imports the System namespace into your program. To access classes and methods from the System namespace, like Console for input/output operations. Without this line, you'd need to write System.Console.WriteLine instead of Console.WriteLine.
2.	class Program : Defines a class named Program. In C#, everything resides in classes. A program must have at least one class, and Program is the default name given to the main class. You can name the class anything you want, but it’s good practice to use meaningful names.
3.	static void Main(string[] args)
o	static: Means this method belongs to the class itself, not an instance of the class. It can be called without creating an object of the class.
o	void: Indicates that the method does not return any value.
o	Main: This is the entry point of a C# program. When the program runs, execution starts from this method.
o	string[] args: Represents command-line arguments passed to the program. It’s optional, and you can leave it out if you don’t need command-line arguments.
4.	Console.WriteLine("Hello, World!");
o	Console: A class in the System namespace used for input/output operations.
o	WriteLine: A method of the Console class that prints text to the console, followed by a new line.
o	"Hello, World!": The string to be printed.
*/
