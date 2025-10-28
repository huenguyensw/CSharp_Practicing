// Goal: Practice Delegates and LINQ.
// Define:

// delegate bool Filter<T>(T item);


// Create a method:

// List<T> FilterList<T>(List<T> items, Filter<T> filter)
// {
//     return items.Where(i => filter(i)).ToList();
// }


// Use it with:

// var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
// var evens = FilterList(numbers, n => n % 2 == 0);


// Test with xUnit:
// ✅ Ensure that FilterList returns [2,4,6].



using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

public class DelegateBasedFiltering
{
    public delegate bool Filter<T>(T item);
    public List<T> FilterList<T>(List<T> items, Filter<T> filter)
    {
        return items.Where(i => filter(i)).ToList();
    }

    public void Run()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
        List<int> evens = FilterList(numbers, n => n % 2 == 0);

        foreach (int i in evens)
        {
            Console.Write($"{i}, ");

        }
    }

}