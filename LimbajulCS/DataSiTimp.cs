using System;


namespace DataSiTimp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2018, 11, 19);
            Console.WriteLine(date);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(date.Year);
            Console.WriteLine(date.DayOfWeek + " " + date.DayOfYear);
            Console.WriteLine(date.Month);
            TimeSpan timp = new TimeSpan(3, 54, 30);
            Console.WriteLine(timp);
          
                Console.WriteLine(timp.Subtract(new TimeSpan(2, 15, 54)));

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
