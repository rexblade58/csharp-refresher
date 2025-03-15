namespace Refresher.Concepts
{
    public class MethodsExample
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static void TestMethod(ref int x)
        {
            x++;
        }

        public static bool SecondMethod(int value)
        {
            return value < 100;
        }
    }
}