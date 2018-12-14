using System;



    class Tablouri
    {
        static void Main(string[] args)
        {
        int n;
        n = int.Parse(Console.ReadLine());
        int[] a;
        a = new int[n];
        for (int i = 0; i < n; i++)
            a[i] = int.Parse(Console.ReadLine());
        foreach(int numar in a)
            Console.Write(numar+"\t");
        Console.Write(a.Length);
        int[] b;
        b = new int[n];
        a.CopyTo(b, 0);
        foreach (int numar in a)
            Console.Write(numar + "\t");
        Console.WriteLine("\n"+a.Rank);

        int[] c = new int[] { 1, 2, 3, 4, 5 };
        var e = new [] { 1, 2, 3, 4, 5 };

        Array.Reverse(c);
        Console.WriteLine();
        foreach (int val in c)
            Console.Write(val + "\t");
        Console.WriteLine();
        Array.Sort(a);
        foreach (int val in c)
            Console.Write(val + "\t");
        Console.WriteLine();
        int[,] matrice = new int[2, 2]{{0,1},{2,1}};
        int lines = matrice.GetUpperBound(0)+1;
        int columns = matrice.GetUpperBound(1)+1;
        for(int i=0;i<lines;i++)
        {
            for (int j = 0; j < columns; j++)
                Console.Write(matrice[i, j] + " ");
            Console.WriteLine();
        }
        /*trei vectori de dimensiuni  diferite
         * 
         * */
        int[][] jagged = new int[3][];
        jagged[0] = new int[] { -5, 6, 7, 8, 9 };
        jagged[1] = new int[] { 0, 0, 1, 2, 0, 3, 4, 5, 6, -6, 7 };
        jagged[2] = new int[] { 2, 0 };
        for (int i = 0; i < jagged.Length; i++)
        {
            Console.Write("jagged[{0}]=(", i);
            for (int j = 1; j < jagged[i].Length; j++)
                Console.Write(jagged[i][j] + " ");
            Console.WriteLine(")");

        }
        /*Matrice 2x2, in care fiecare element este 
         * si el o matrice
         * */
        int[,][,] mm = new int[2, 2][,];
        /*
         * Matrice de vectori
         * */
        int[,][] mme = new int[2, 2][];
        /*
         * Matrice de matrice de vectori
         * */
        int[,][,][] mmee = new int[2, 2][,][];
        /*
         * Vector de vector de vectori
         * 
         * */
        int[][][] que = new int[3][][];
        /*
         * Un vector de matrici, de matrici, de matrici
         * */
        int[][,][,][,] qw = new int[4][,][,][,];
        /*
         * Un vector de matrici de vector de matrici
         * */
        int[][,][][,] dwdw = new int[5][,][][,];

        /*
         * 
         * O matrice de matrice in care fiecare element
         * este un vector de vectori 
         * */
        int[,][,][][] dwdwdw = new int[6, 7][,][][];
       



        


        

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }

