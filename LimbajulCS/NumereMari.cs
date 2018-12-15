using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace LimbajulCS
{
    class NumereMari
    {
        static void Main()
        {
            BigInteger big = new BigInteger(3334234234234234);
           
            Console.WriteLine(big);
            big = BigInteger.Parse("342342938492348239482349028394023849023849203842903482934");
            Console.WriteLine(big);
            big = BigInteger.Add(big, BigInteger.Parse("-3423423423423423423423423423423423423"));
            Console.WriteLine(big);
        
          BigInteger.DivRem(big, 2, out big);
            Console.WriteLine(big);
            big = BigInteger.Parse("3243948239048239408234908234908239408239482394823948234");
            big = BigInteger.Pow(big, 200);
            Console.WriteLine(big);
            big = BigInteger.ModPow(big, 200, 134);
            Console.WriteLine(big);
            Console.ReadKey();
            return;
        }
    }
}
