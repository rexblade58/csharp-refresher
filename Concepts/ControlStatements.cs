using System;

namespace Refresher.Concepts
{
    public class ControlStatements
    {
        public static void IfElseExample(int result)
        {
            if (result > 10)
                Console.WriteLine("Result is greater than 10");
            else
                Console.WriteLine("Result is 10 or less");
        }

        public static void SwitchExample(int number)
        {
            switch (number)
            {
                case 42:
                    Console.WriteLine("The answer to everything is 42");
                    break;
                case 100:
                    Console.WriteLine("The number is 100");
                    break;
                default:
                    Console.WriteLine("Unknown number");
                    break;
            }
        }

        public static void ShowLoops()
        {
            Console.WriteLine("For Loop:");
            for (int i = 1; i <= 5; i++)
                Console.WriteLine(i);

            Console.WriteLine("\nWhile Loop:");
            int j = 6;
            while (j <= 10)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine("\nDo-While Loop:");
            int k = 11;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k <= 15);
        }
    }
}