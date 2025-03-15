using System;

namespace Refresher.Concepts
{
    public class ArrayExample
    {
        public static void PrintFruits()
        {
            string[] fruits = { "Apple", "Banana", "Cherry" };

            foreach (var fruit in fruits)
                Console.WriteLine(fruit);
        }
    }
}