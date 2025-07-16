using System;

namespace Refresher.Concepts
{
    public class VariablesExample
    {
        public static void DisplayVariables()
        {
            int number = 42;
            double pi = 3.14;
            char letter = 'A';
            string message = "Hello C#!";
            bool isActive = true;

            Console.WriteLine($"Integer: {number}");
            Console.WriteLine($"Double: {pi}");
            Console.WriteLine($"Char: {letter}");
            Console.WriteLine($"String: {message}");
            Console.WriteLine($"Boolean: {isActive}");
        }
    }
}