using System;

public static class InterfacesDemo
{
    public static void Run()
    {
        Console.Clear();

        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        car.Move();
        bicycle.Move();

        PromptContinue();
    }

    private static void PromptContinue()
    {
        Console.WriteLine("\nPress Enter to return to menu...");
        Console.ReadLine();
    }
}

public interface IMovable
{
    void Move();
}

public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

public class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}
