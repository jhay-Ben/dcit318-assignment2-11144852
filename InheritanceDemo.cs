using System;

public static class InheritanceDemo
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("Choose an animal:");
        Console.WriteLine("1. Animal");
        Console.WriteLine("2. Dog");
        Console.WriteLine("3. Cat");
        Console.Write("Enter choice (1-3): ");

        if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 3)
        {
            Console.WriteLine("Invalid choice.");
            PromptContinue();
            return;
        }

        Animal animal = choice switch
        {
            1 => new Animal(),
            2 => new Dog(),
            3 => new Cat(),
            _ => null
        };

        animal.MakeSound();
        PromptContinue();
    }

    private static void PromptContinue()
    {
        Console.WriteLine("\nPress Enter to return to menu...");
        Console.ReadLine();
    }
}

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}
