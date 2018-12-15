using System;



    class Functii
    {

         static void Salutare(string nume)
    {
        Console.WriteLine($"Hello,{nume}!");
    }
       static int Suma(int x, int y)
    {
        return x + y;
    }
    static  bool Sedivide(uint a, uint b)
    {
        return a % b == 0;
    }
    static  void swap(ref int a, ref int b)
    {
        int aux = a;
        a = b;
        b = aux;
    }
    static void sumacif(int numar, out int suma)
    {
        suma = 0;
        while(numar!=0)
        {
            suma = suma + numar % 10;
            numar = numar / 10;
        }
    }
    static int Maxim(params int[] ints)
    {
        int max = int.MinValue;
        for (int i = 0; i < ints.Length; i++)
            if (ints[i] > max)
                max = ints[i];
        return max;
    }
    static double Maxim(params double[] ints)
    {
        double max = double.MinValue;
        for (int i = 0; i < ints.Length; i++)
            if (ints[i] > max)
                max = ints[i];
        return max;
    }

    static bool Ndivide(int n, params int[] ints)
    {
        for (int i = 0; i < ints.Length; i++)
            if (ints[i] % n != 0)
                return false;
        return true;
    }
    /*
    static bool Ndivide(params int[] ints, int n)
    {
        for (int i = 0; i < ints.Length; i++)
            if (ints[i] % n != 0)
                return false;
        return true;
    }
    */
    static int[] numere_pare(int n)
    {
        int[] pare;
        pare = new int[n / 2];
        for (int i = 0; i < pare.Length; i++)
            pare[i] = 2 * (i + 1);
        return pare;
    }
    static double Maritmetic(int a, int b=0)
    {
        return (a + b) / 2;
    }
        static void Main(string[] args)
        {
            string[] nume = new string[] { "Ioan", "Mircea", "Ionela", "Ana" };
            foreach (string s in nume)
                Salutare(s);
            Console.WriteLine("3+5=" + Suma(3, 5));
            int x = 5, y = -6;
            Console.WriteLine("5-6=" + Suma(x, y));
            Console.WriteLine("4%2=0?==>" + Sedivide(4, 2));
        Console.WriteLine("10%5=0?==>" + Sedivide(b: 5, a: 10));
        // Console.WriteLine("10%5=0?==>" + Sedivide(b: 5,10));
        int a = 3, b = 4;
        Console.WriteLine($"a={a},b={b}\n(Interschimbare)");
        swap(ref a, ref b);
       //SAU swap(b: ref a, a: ref b);
        Console.WriteLine($"a={a},b={b}(Interschimbare)");
        sumacif(13, out b);
        Console.WriteLine(b);
        Console.WriteLine(Maxim(3, 4, 5, 6, 7));
        Console.WriteLine(Maxim(3.5, 4.7, 6.7, -4.5, 11.225));
        Console.WriteLine(Maxim(new int[] { 1, 2, 3, 4, 5, 6, -7, 9 }));
        Console.WriteLine(Ndivide(2, new int[] { 2, 4, 5, 6, 7, 8, 9 }));

        Console.WriteLine(Maritmetic(3, 4));
        Console.WriteLine(Maritmetic(16));
        Console.WriteLine(Maritmetic(b: 4, a: 5));


        foreach (var s in numere_pare(25))
            Console.Write(s + " ");

        




      
            Console.ReadKey();
        }
    }

