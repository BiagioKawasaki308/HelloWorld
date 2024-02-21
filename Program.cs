using System;

namespace MyNamespace
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "! How are you?");
            Console.WriteLine("Enter a number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            int b = int.Parse(Console.ReadLine());
            int result = a + b;
            Console.WriteLine("The result is " + result + "!");
        }
    }
}
