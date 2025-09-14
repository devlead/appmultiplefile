namespace Models;

public class Cat : Pet
{
    public void Mjau()
    {
        Console.WriteLine($"{Name} says: Mjau!");
    }

    public override void MakeSound()
    {
        Mjau();
    }
}