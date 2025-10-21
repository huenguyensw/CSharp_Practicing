public class Animal
{
    public virtual string Speak()
    {
        return "Animal sound";
    }

}

public class Dog : Animal
{
    public override string Speak()
    {
        return "Dog says: Woof!";
    }
}

public class Cat : Animal
{
    public override string Speak()
    {
        return "Cat says: Meow!";
    }
}