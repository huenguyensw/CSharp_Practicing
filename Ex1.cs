// Create a generic class Repository<T> with methods:
// Add(T item)
// GetAll()
// Find(Func<T, bool> predicate)

// Create a class Person with:
// public string Name { get; set; }
// public int Age { get; set; }

namespace Hue2
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}


public class Repository<T>
{
    private List<T> items = new List<T>();

    public void Add(T item) => items.Add(item);

    public List<T> GetAll()
    {
        return items;
    }

    public List<T> Find(Func<T,bool> predicate)
    {
        List<T> result  = new List<T>();
        foreach (var item in items)
        {
            if (predicate(item))
            {
                result.Add(item);
            }
        }

        return result;
    }
}