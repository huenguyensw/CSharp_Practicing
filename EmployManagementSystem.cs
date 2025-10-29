// Exercise 3: Employee Management System

// Goal: Combine OOP, LINQ, and Generics.

// Classes:

// Employee(properties: Id, Name, Department, Salary)

// EmployeeRepository<T>(generic repository)

// Use LINQ to:

// Get average salary per department

// Get top 3 highest paid employees

// Get all employees whose name starts with “A”

// xUnit Tests:
// Test that filtering and sorting logic works correctly.

public class Employee
{
    public int Id{ get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public float Salary { get; set; }

    

}

public class EmployeeRepository<T>
{
    private List<T> items = new List<T>();

    public void Add(T item) => items.Add(item);

    public List<T> GetAll()
    {

        return items;
    }


    public List<T> GetValues(Func<T, bool> predicate)
    {
        List<T> result = items.Where(predicate).ToList();
        return result;
    }

    
}