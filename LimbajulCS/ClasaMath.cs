using System;

namespace MathFunctions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("{0:F3}", Math.PI);
            Console.WriteLine("{0:F2}", Math.E);
            Console.WriteLine(Math.Abs(-27.3));
            Console.WriteLine("{0:F2}", Math.Sqrt(16.78));
            Console.WriteLine(Math.Sin(Math.PI / 6));
            Console.WriteLine(Math.Cos(Math.PI / 6));
            Console.WriteLine(Math.Truncate(3.0167));
            Console.WriteLine(Math.Ceiling(3.8905));

            Console.ReadKey();
        }
    }
}

