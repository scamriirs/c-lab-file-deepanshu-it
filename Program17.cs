// 17. Concept to illustrate overloading an indexer. 
using System;

class IndexedArray
{
    private int[] arr = new int[10];

    public int this[int index]
    {
        get => arr[index];
        set => arr[index] = value;
    }

    public int this[int index, int multiplier]
    {
        get => arr[index] * multiplier;
    }
}

class Program
{
    static void Main()
    {
        IndexedArray obj = new IndexedArray();
        obj[0] = 5;
        Console.WriteLine("Value at index 0: " + obj[0]);
        Console.WriteLine("Multiplied value at index 0: " + obj[0, 2]);
    }
}
