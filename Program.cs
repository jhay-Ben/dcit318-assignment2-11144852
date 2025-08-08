using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("DCIT 318 - Assignment 2");
            Console.WriteLine("1. Inheritance and Method Overriding");
            Console.WriteLine("2. Abstract Classes and Methods");
            Console.WriteLine("3. Interfaces");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option (1-4): ");

            switch (Console.ReadLine())
            {
                case "1":
                    InheritanceDemo.Run();
                    break;
                case "2":
                    AbstractClassesDemo.Run();
                    break;
                case "3":
                    InterfacesDemo.Run();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again...");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
