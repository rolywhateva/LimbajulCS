using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimbajulCS
{
    class FIFOLIFO
    {
        static void Main()
        {
            Stack stiva = new Stack();
            for (int i = 1; i <= 10; i++)
                stiva.Push(i);
            Console.WriteLine(stiva.Count);
            Console.WriteLine(stiva.Contains(1));
            Console.WriteLine(stiva.Peek());
            while(stiva.Count>0)
                Console.WriteLine(stiva.Pop());
            Queue coada = new  Queue();
            for (int i = 0; i < 9; i++)
                coada.Enqueue(i);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(coada.Count);
            Console.WriteLine(coada.Contains(10));
            while(coada.Count>0)
            {
                Console.WriteLine(coada.Dequeue());
            }


            Console.ReadKey();


            return;
        }
    }
}
