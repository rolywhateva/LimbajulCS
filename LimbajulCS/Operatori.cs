using System;
class Operatori
{
        static void Main(string[] args)
        {
        #region Aritmetici
        int a = 3, b = 5;
        int sum = a + b, dif = a - b, prod = a * b, 
        cat = a / b, rest = a % b;
        Console.WriteLine("{0}+{1}={2}", a, b, sum);
        Console.WriteLine("{0}-{1}={2}", a, b, dif);
        Console.WriteLine("{0}*{1}={2}", a, b, prod);
        Console.WriteLine("{0}/{1}={2}", a, b, cat);
        Console.WriteLine("{0}%{1}={2}", a, b, rest);
        #endregion
        #region Relationali
        bool e1 = (3 < 5);
        bool e2 = (5 > 3);
        bool e3 = (3 <= 5);
        bool e4 = (5 >= 3);
        bool e5 = (5 == 5);
        #endregion
        #region Logici 
        bool l1 = (true && true);
        bool l2 = (true || true);
        bool l3 = (!true);
        bool l4 = (true ^ false);
        #endregion
        #region pe biti
        int u = 3, t = 5;
        u = u & u;
        t = t | t;
        u = u ^ u;
        u = u << 2;  // <===> u = u* 2^2;
        t = t >> 2;// <===> t = t *2^2;
        #endregion
        #region atribuire
        int var = 3; // atribuire simpla
        int q, w, e;
        q = w = e = 3; // atribuire  multipla(incepe de la dreapta) 
        q += 3; // <===> q = q  +3;
                //Analog  -,*,/,%, operatori binari 
        #endregion
        #region  incrementare/decrementare 
        int i = 3, j = 4;
        j = (i++) * 4;
        j = (++i) * 4;
        //Analog pentru --
        #endregion






        Console.WriteLine("Apasati enter");
         Console.ReadKey();
        }
}

