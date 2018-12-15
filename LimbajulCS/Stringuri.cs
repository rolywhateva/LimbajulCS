using System;



    class Stringuri
    {
        static void Main(string[] args)
        {
            string s;
            s = "Hello";
            Console.WriteLine("s={0}", s);
            Console.WriteLine(s.Length);
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.Contains("ll"));
            Console.WriteLine(s.Contains("zswdqwse"));
            Console.WriteLine(s.Insert(2, "Hello"));
            Console.WriteLine(s + " " + "World!");
        Console.WriteLine(s.PadLeft(5));
        Console.WriteLine(s.PadRight(5));
        Console.WriteLine(s.Substring(0, 3));
        Console.WriteLine(s.Replace('l', 'e'));
        Console.WriteLine(string.Format("{0},{1},{2}", 1, 2, 3));
        Console.WriteLine(string.Format($"{s + " World!"})"));
        int a = 3, b = 4, c = 5;
        Console.WriteLine($"{a}+{b}-{c}={a + b - c}"); // interpolare
        string[] cuvinte;
        string p = "Ana are mere";
        cuvinte = p.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
        //sau cuvinte = p.Split(' ');
        for (int i = 0; i < cuvinte.Length; i++)
            Console.Write(cuvinte[i] + "\n");
        Console.WriteLine(string.Join(".", cuvinte));
        Console.WriteLine("string.Compare(\"Mama\", \"Macara\")="+string.Compare("Mama","Macara"));
        Console.WriteLine(s);

          
            Console.ReadKey();
        }
    }

