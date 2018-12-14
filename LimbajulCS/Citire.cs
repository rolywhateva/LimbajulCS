using System;
namespace Citire
{
    class Program
    {
        static void Main()
        {
            int d;
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("Ati introdus : " + d);
            Console.WriteLine("Apasati enter");
            //Analog: celelalte tipuri de date
            //Mai frumos
            bool ok;
            do
            {
                Console.WriteLine("Dati un numar intreg:");

                ok = int.TryParse(Console.ReadLine(), out d);
                if(!ok)
                {
                    Console.WriteLine("Format incorect!");
                }
            } while (!ok);
            Console.WriteLine("d="+d);
            Console.ReadKey();

        }
    }
}

