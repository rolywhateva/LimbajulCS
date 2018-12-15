using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    TIPURILE VALOARE
    (tipurile de baza, struct)
    -Nu au  o clasa cu o nume identica cu a lor
    (ex.nu exists un System.Struct, spre exemplu) 
    -Sunt alocate pe stiva, fiind  distruse la iesirea din functie(scope)
    -Sunt initializate cu valorile lor implicite(int cu 0, bool cu false, etc..)
    -Cand sunt aplicate cu  operatorul "==", atunci sunt comparate valorile
    -La atribuire se atribuie valoarea
    TIPURILE REFERINTA
    (orice  clasa, string, delegatele,array etc.) 
    -Au o clasa cu o nume identica cu a lor
    (Ex. System.Array) 
    -Sunt alocate in heap, fiind distruse de Garbage Collector 
    -Sunt initializate cu null
    -Cand sunt aplicate cu operatorul "==", atunci sunt comparatele adresele
    la care se refera
     -La atribuire se  atribuie  adresa 
    



 */

namespace LimbajulCS
{
    
     static class ValoareSiReferinta
    {
        static  string  Write(int[] a)
        {
            return string.Join(" ", a);
        }

        static void Modify1(int[] a)
        {
            a = new int[] { 100, 100, 100, 100 };
            Console.WriteLine("In apelul Modify 1 :" + Write(a));
        }
        static void Modify2(ref int[] a)
        {
            a = new int[] { 100, 100, 100, 100 };
            Console.WriteLine("In apelul Modify 2:"+Write(a));
        }
        static void Main()
        {
            int d = 0;
            if (d == 0)
                Console.WriteLine(d);
            string s = null;
            if (s == null)
                Console.WriteLine("Stringul este null");
            int[] a = { 1, 2, 3, 4 };
            Console.WriteLine("Inainte apelul Modify 1 :" + Write(a));
            Modify1(a);
            Console.WriteLine("Dupa apelul Modify 1 :" + Write(a));
            Modify2(ref a);
            Console.WriteLine("Dupa apelul Modify 2:"+Write(a));





            Console.ReadKey();
           

        }

    }
}

