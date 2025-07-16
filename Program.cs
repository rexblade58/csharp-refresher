using System;
using Refresher.Concepts;

namespace Refresher
{
    internal class Program
    {
        static PlayerState playerState = PlayerState.Idle;
        static int variable = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("--- ENUM EXAMPLE ---");
            EnumExample.ShowPlayerState(playerState);

            Console.WriteLine("\n--- VARIABLES EXAMPLE ---");
            VariablesExample.DisplayVariables();

            Console.WriteLine("\n--- METHODS EXAMPLE ---");
            int result = MethodsExample.Add(5, 10);
            Console.WriteLine($"Add(5, 10) = {result}");
            MethodsExample.TestMethod(ref variable);
            Console.WriteLine($"Variable after TestMethod: {variable}");
            bool check = MethodsExample.SecondMethod(50);
            Console.WriteLine($"SecondMethod(50) = {check}");

            Console.WriteLine("\n--- CONTROL STATEMENTS EXAMPLE ---");
            ControlStatements.IfElseExample(result);
            ControlStatements.SwitchExample(42);
            ControlStatements.ShowLoops();

            Console.WriteLine("\n--- ARRAY EXAMPLE ---");
            ArrayExample.PrintFruits();

            Console.WriteLine("\n--- USER INPUT EXAMPLE ---");
            UserInputExample.AskName();

            Console.WriteLine("\n--- CLASS EXAMPLE ---");
            MyClass myClass = new MyClass();
            myClass.MyMethod();

            Console.ReadKey();
        }
    }
}