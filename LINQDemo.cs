/* Given a list of people(name, age):
Get all names where age > 18
Sort by name alphabetically¨*/
class LINQDemo
{
    public void Run(Person[] people)
    {

        var adults = from person in people
                     where person.Age > 18
                     orderby person.Name
                     select person.Name;

        foreach (var name in adults)
        {
            Console.WriteLine(name);
        }
    }

}


public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

