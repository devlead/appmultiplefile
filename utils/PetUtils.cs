using Models;

namespace Utils;

public static class PetUtils
{
    public static void MakeAllPetsSound(IEnumerable<Pet> pets)
    {
        foreach (var pet in pets)
        {
            pet.MakeSound();
        }
    }

    public static List<Pet> CreateSamplePets()
    {
        return new List<Pet>
        {
            new Cat { Name = "Whiskers" },
            new Dog { Name = "Buddy" },
            new Cat { Name = "Fluffy" },
            new Dog { Name = "Max" }
        };
    }

    public static void DisplayPetInfo(Pet pet)
    {
        Console.WriteLine($"Pet Name: {pet.Name}");
        Console.WriteLine($"Pet Type: {pet.GetType().Name}");
        Console.Write("Sound: ");
        pet.MakeSound();
        Console.WriteLine();
    }

    public static List<T> GetPetsOfType<T>(List<Pet> pets) where T : Pet
    {
        return pets.OfType<T>().ToList();
    }

    public static int CountPetsByType<T>(List<Pet> pets) where T : Pet
    {
        return pets.OfType<T>().Count();
    }
}