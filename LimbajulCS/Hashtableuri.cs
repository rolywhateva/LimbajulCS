using System;
using System.Collections;

namespace LimbajulCS
{
    class Hashtableuri
    {
        static void Main()
        {
            //Hashtable =  o structura de date
            // care atribuie  fiecarei valori
            // o cheie(o alta valoare)
            Hashtable table = new Hashtable();
            table.Add("a", 123);
            table.Add("b", 124);
            table.Add("c", 125);
            Console.WriteLine(table["a"]); //123
            Console.WriteLine(table["b"]);//124
            table.Clear();
            for (int i = 0; i <'z'-'a'+1; i++)
                table.Add((char)('a' + i), i + 1);
            foreach (DictionaryEntry entry in table)
            {
                Console.WriteLine("{0}, {1}", entry.Key, entry.Value);
            }
            Console.WriteLine(  table.ContainsKey('0'));
            Console.WriteLine(table.ContainsValue(456));
            Console.WriteLine(table.Count);
            var keys = table.Keys;
            foreach(var x in keys)
                Console.WriteLine(x);
          


            Console.ReadKey();
            return;
        }
    }
}
