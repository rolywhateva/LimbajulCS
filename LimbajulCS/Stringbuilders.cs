using System;
using System.Text;

namespace Stringbuilders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StringBuilder s = new StringBuilder();
            s.Append("Vagana");
            s.Insert(0, "I love my ");
            s.Insert(s.Length, "." + s.ToString());
         
           // Console.WriteLine(s.ToString());
            s.Replace("Vagana", "dick");
            Console.WriteLine(s.ToString());
            Console.WriteLine(s.Append('0',3));
            Console.WriteLine(s.ToString());
           

            Console.ReadKey();
        }
    }
}
