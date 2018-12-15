using System;
using System.IO;
using System.Collections.Generic;
    class Fisiere
    {
        static void Main()
        {
     
        string line;
        try
        {
            using (StreamReader reader = new StreamReader("Entry.txt"))
            {
            
                do
                {
                    line = reader.ReadLine();
                    Console.WriteLine(line);
                } while (line != null);
            }

        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Random r = new Random();
        List<int> numere = new List<int>();
        int n = 100;
        for (int i = 1; i <= 15; i++)
            numere.Add(r.Next() % n);
        StreamWriter writer = new StreamWriter("Exit.txt",true);//append
        foreach (int i in numere)
            writer.Write(i + "\t");
        writer.WriteLine();
        writer.Close();
        Console.ReadKey();

        }
    }

