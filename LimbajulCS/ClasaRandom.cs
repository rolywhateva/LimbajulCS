using System;



    class ClasaRandom
    {
        static void Main()
        {
        Random r = new Random();
        //r.Next(20); <==> r.Next()%20;
        Console.WriteLine(r.Next());
        Console.WriteLine(r.Next() % 10);
        for (int i = 0; i < 10; i++)
            Console.Write(r.Next() % 20 + "\t");
        Console.WriteLine();
        Random q = new Random(4);
        for (int i = 0; i < 10; i++)
            Console.Write(q.Next() % 20 + "\t");
        Console.WriteLine();
        for (int i = 0; i < 10; i++)
            Console.Write("{0:F3}\t",q.NextDouble() * Math.Pow(10, q.Next() %3));






        Console.ReadKey(); 

    }
    }

