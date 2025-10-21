using System.Globalization;

delegate List<int> Numbers(List<int> nums);

class DelegateDemo
{
    public void Run()
    {
        List<int> nums = new List<int> { 1, 2, 3, 4 };

        Numbers getnumbers = numbers => numbers.FindAll(n => n % 2 != 0);

        List<int> evenNumbers = getnumbers(nums);
        
        Console.WriteLine(string.Join(", ", getnumbers(nums))); // Output: 2, 4
    }
}