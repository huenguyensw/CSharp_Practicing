using System.Transactions;

namespace Company.HR
{
    public class  Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public Employee(string name, string position)
        {
            Name = name;
            Position = position;
        }

        public void Promote(string newPosition)
        {
            Position = newPosition;

        }
    }
}