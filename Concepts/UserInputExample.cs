using System;

namespace Refresher.Concepts
{
    public class UserInputExample
    {
        public static void AskName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome, {name}!");
        }
    }
}