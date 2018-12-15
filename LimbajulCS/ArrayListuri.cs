using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimbajulCS
{
    class ArrayListuri
    {
        static void Main()
        {
            //Un arrayList contine mai multe valori de tipuri diferite
            //ArrayList-urile nu sunt eficiente
            ArrayList list = new ArrayList();
            Random rnd = new Random();
            for (int i = 0; i < 9; i++)
                list.Add(rnd.Next() % 100);
            ArrayList floats = new ArrayList(new float[] { 1.23f, -2.34f, (float)Math.PI });
            list.AddRange(floats);
            ArrayList chars = new ArrayList(new char[] { 'c', 'd', '.' });
            list.AddRange(chars);
            int integers = 0, reals = 0, letters = 0;
            for (int i = 0; i < list.Count; i++)
                if (list[i] is int)
                    integers++;
                else
                     if (list[i] is char)
                    letters++;
                else if (list[i] is float)
                    reals++;
            Console.WriteLine("Integers:" + integers);
            Console.WriteLine("Reals:" + reals);
            Console.WriteLine("Letters:" + letters);
          //  list.Sort(); <-- Eroare! Valorile nu au tipuri identice
          // Deci sortarea este imposibila
          //Implementeaza QuickSort
            foreach (var s in list)
                Console.Write(s + "\t");
            list.Reverse();
            Console.WriteLine();
            foreach(var s in list)
                Console.Write(s+"\t");
            ArrayList bucata = new ArrayList(list.GetRange(2, 2));
            Console.WriteLine("\nBucata [2,3] din list :");
            foreach(var  v in bucata)
                Console.Write(v+"\t");
            Console.WriteLine();
            list.SetRange(0, new bool[] { true, true, false, false, true });
            foreach (var v in list)
                Console.Write(v + "\t");
            Console.WriteLine(list.IndexOf(3));
            Console.WriteLine(list.LastIndexOf(3));



            Console.ReadKey();
           


            return;
        }
    }
}
