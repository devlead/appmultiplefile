namespace Models;

public class Dog : Pet
{
    public void Bark()
    {
        Console.WriteLine($"{Name} says: Bark!");
    }

    public override void MakeSound()
    {
        Bark();
    }
}