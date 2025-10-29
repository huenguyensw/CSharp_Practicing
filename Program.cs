using MathLibrary;
using Geometry;
using System;
using Company.HR;
using Practicing;
using System.Linq;
using Hue2;
using System.Reflection.Metadata.Ecma335;
using System.Reflection;
using System.Runtime.CompilerServices;

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
            Console.WriteLine($"Area of Circle: {Math.Round(circle.GetArea(5), 2)}");

            // var employee1 = new Employee("Alice", "Developer");
            // var employee2 = new Employee("Bob", "Designer");


            // Console.WriteLine($"Employee 1: {employee1.Name}, Position: {employee1.Position}");
            // Console.WriteLine($"Employee 2: {employee2.Name}, Position: {employee2.Position}");

            // employee1.Promote("Senior Developer");
            // Console.WriteLine($"Employee 1 Promoted to: {employee1.Position}");

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

            Person[] people =
            {
                new Person { Name = "John", Age = 25 },
                new Person { Name = "Jane", Age = 17 },
                new Person { Name = "Alice", Age = 30 },
                new Person { Name = "Bob", Age = 15 }
            };
            LINQDemo linqDemo = new LINQDemo();
            linqDemo.Run(people);

            Calculator calcDemo = new Calculator();
            int result = calcDemo.Add(10, 20);
            Console.WriteLine($"Calculator Add Result: {result}");
            int subResult = calcDemo.Subtract(20, 10);
            Console.WriteLine($"Calculator Subtract Result: {subResult}");




            var repo = new Repository<Person>();
            repo.Add(new Person { Name = "Alice", Age = 24 });
            repo.Add(new Person { Name = "Jane", Age = 48 });

            var adults = repo.Find(p => p.Age >= 18);

            Console.WriteLine($"Adults include:");

            foreach (var adult in adults)
            {
                Console.WriteLine($"- {adult.Name}({adult.Age})");
            }

            DelegateBasedFiltering delegateBasedFilteringDemo = new DelegateBasedFiltering();
            delegateBasedFilteringDemo.Run();


            var employRepo = new EmployeeRepository<Employee>();
            employRepo.Add(new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 35000 });
            employRepo.Add(new Employee { Id = 2, Name = "Mary", Department = "IT", Salary = 45000 });
            employRepo.Add(new Employee { Id = 3, Name = "Alex", Department = "R&D", Salary = 48000 });
            employRepo.Add(new Employee { Id = 4, Name = "Jone", Department = "R&D", Salary = 38000 });
            employRepo.Add(new Employee { Id = 5, Name = "Doe", Department = "HR", Salary = 28000 });
            employRepo.Add(new Employee { Id = 6, Name = "Alexande", Department = "Sale", Salary = 18000 });




            var AvSalaryPerDeparment = employRepo.GetAll()
            .GroupBy(e => e.Department)
            .Select(g => new
            {
                depart = g.Key,
                avSalary = g.Average(e => e.Salary)
            });
            foreach (var item in AvSalaryPerDeparment)
            {
                Console.WriteLine($"Salary Avarage of {item.depart} department is: {item.avSalary}");
            }

            var TopThreeHighest = employRepo.GetAll()
            .OrderByDescending(e => e.Salary)
            .Take(3)
            .ToList();
            Console.WriteLine($"Top 3 employees with highest salary includes:");
            foreach (var item in TopThreeHighest)
            {
                Console.WriteLine($"{item.Name} ({item.Salary}), ");
            }


            var EmployeeStartWithA = employRepo.GetValues(e => e.Name.StartsWith("A"));
            Console.WriteLine($"Employees starts with A:");
            foreach (var item in TopThreeHighest)
            {
                Console.Write($"{item.Name}, ");
            }

        }
    }
}