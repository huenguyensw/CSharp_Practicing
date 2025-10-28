using System;
using System.Collections.Generic;

public class Generics
{
    public void Run()
    {
        List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
        List<int> ages = new List<int> { 25, 30, 35 };
        Console.WriteLine(GetFirst(ages)); // Output: 1
        Console.WriteLine(GetFirst(names));   // Output: Alice
    }

    public Q GetFirst<Q>(List<Q> items)
    {
        return items[0];
    }
}