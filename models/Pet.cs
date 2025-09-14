namespace Models;

public abstract class Pet
{
    public required string Name { get; set; }

    public abstract void MakeSound();
}
