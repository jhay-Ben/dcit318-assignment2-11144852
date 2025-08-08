using System;

public static class AbstractClassesDemo
{
    public static void Run()
    {
        Console.Clear();

        // Ask for circle radius
        Console.Write("Enter the radius of the circle: ");
        if (!double.TryParse(Console.ReadLine(), out double radius) || radius <= 0)
        {
            Console.WriteLine("Invalid radius. Please enter a positive number.");
            PromptContinue();
            return;
        }
        Shape circle = new Circle(radius);

        // Ask for rectangle dimensions
        Console.Write("Enter the width of the rectangle: ");
        if (!double.TryParse(Console.ReadLine(), out double width) || width <= 0)
        {
            Console.WriteLine("Invalid width. Please enter a positive number.");
            PromptContinue();
            return;
        }

        Console.Write("Enter the height of the rectangle: ");
        if (!double.TryParse(Console.ReadLine(), out double height) || height <= 0)
        {
            Console.WriteLine("Invalid height. Please enter a positive number.");
            PromptContinue();
            return;
        }
        Shape rectangle = new Rectangle(width, height);

        // Output results
        Console.WriteLine($"\nCircle Area: {circle.GetArea():F2}");
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea():F2}");

        PromptContinue();
    }

    private static void PromptContinue()
    {
        Console.WriteLine("\nPress Enter to return to menu...");
        Console.ReadLine();
    }
}

public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

public class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double GetArea()
    {
        return width * height;
    }
}