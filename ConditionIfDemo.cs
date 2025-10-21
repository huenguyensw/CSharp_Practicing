class ConditionIfDemo
{
    public void Run()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} is even");
            }
            else
            {
                Console.WriteLine($"{i} is odd");
            }
        }
    }
}
