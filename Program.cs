using MathLibrary;
using Geometry;
using System;
using Company.HR;
using Practicing;

namespace Hue
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            int sum = calculator.Add(5, 3);
            int difference = calculator.Subtract(5, 3);
            Console.WriteLine($"Sum: {sum}, Difference: {difference}");

            var circle = new Circle();
            Console.WriteLine($"Area of Circle: {Math.Round(circle.GetArea(5),2)}");

            var employee1 = new Employee("Alice", "Developer");
            var employee2 = new Employee("Bob", "Designer");


            Console.WriteLine($"Employee 1: {employee1.Name}, Position: {employee1.Position}");
            Console.WriteLine($"Employee 2: {employee2.Name}, Position: {employee2.Position}");

            employee1.Promote("Senior Developer");
            Console.WriteLine($"Employee 1 Promoted to: {employee1.Position}");

            Practicing.Program.Run();

            Animal myDog = new Dog();
            Animal myCat = new Cat();
            Console.WriteLine(myDog.Speak());
            Console.WriteLine(myCat.Speak());

            Generics demo = new Generics();
            demo.Run();

            DelegateDemo delDemo = new DelegateDemo();
            delDemo.Run();

            ConditionIfDemo condDemo = new ConditionIfDemo();
            condDemo.Run();

        }
    }
}