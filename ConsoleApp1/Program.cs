namespace VirtualPetGame;

public class Pet
{
    public long UniqueID { get; private set; }
    public float Health { get; set; }
    public float Age { get; set; }
    public string Name { get; set; }
    public decimal Money { get; set; }
    public float Happiness { get; set; }

    public Pet(string name)
    {
        Name = name;
    }

    public Pet(string name, float age, float health, float happiness)
    {
        Name = name;
        Age = age;
        Health = health;
        Happiness = happiness;

    }
    public void Eat(float amount)
    {
        Console.WriteLine(Name + " ate " + amount + " food!");
    }

    public void Gamble(int duration)
    {
        Console.WriteLine(Name + " gambled for " + duration + " minutes.");
    }

    public void Play(int duration)
    {
        Console.WriteLine(Name + " played for " + duration + " minutes.");
    }
}



public class VirtualPetManager
{
    public static void Main()
    {
        Pet pet = new("Niggi", 2, 100.0f, 10.0f);
        pet.Eat(50);
        pet.Gamble(30);
        Console.WriteLine(pet.Name + " happiness is " + pet.Happiness);
    }
}