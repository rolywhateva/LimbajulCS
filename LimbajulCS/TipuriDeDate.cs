using System;
namespace TipuriDeDate
{
    class Program
    {
        static void Main()
        {
            #region Tipul intreg
            sbyte minsbyte = sbyte.MinValue;
            sbyte maxsbyte = sbyte.MaxValue;
            short minshort = short.MinValue;
            short maxshort = short.MaxValue;
            byte minbyte = byte.MinValue;
            byte maxbyte = byte.MaxValue;
            int minint = int.MinValue;
            int maxint = int.MaxValue;
            long maxlong = long.MaxValue;
            long minlong = long.MinValue;
            uint minuint = uint.MinValue;
            uint maxuint = uint.MaxValue;
            Console.WriteLine("minsbyte={0} maxsbyte={1}", minsbyte, maxsbyte);
            Console.WriteLine("minbyte={0} minbyte={1}", minbyte, maxbyte);
            Console.WriteLine("minshort={0} maxshort={1}", minshort, maxshort);
            Console.WriteLine("minint={0} maxint={1}", minint, maxint);
            Console.WriteLine("minuint={0} maxuint={1}", minuint, maxuint);
            Console.WriteLine("minlong={0} maxlong={1}", minlong, maxlong);
            #endregion
            #region Tipul real
            float minFloat, maxFloat;
            minFloat = float.MinValue;
            maxFloat = float.MaxValue;
            Console.WriteLine("minFloat = {0}", minFloat);
            Console.WriteLine("maxFloat ={0}", maxFloat);
            Console.WriteLine("epsilon:" + float.Epsilon);
           
            Console.WriteLine("Infinity:"+float.PositiveInfinity.ToString());
            Console.WriteLine("Negative Infinity:"+float.NegativeInfinity.ToString());
            Console.WriteLine("Not a number:"+float.NaN);
            float d = 2.13f;
            Console.WriteLine("d={0:F1}", d);
            double minDouble, maxDouble;
            minDouble = double.MinValue;
            maxDouble = double.MaxValue;
            Console.WriteLine("Max Double:"+maxDouble);
            Console.WriteLine("Min double:" + minDouble);
            /*Analog :+/- infinit, epsilon,NaN*/
            Console.WriteLine("{0:F3}",3.1234234234234234);
             
            


            #endregion

            #region caracter
            char a = 'x';
            Console.WriteLine(char.ToLower(a));
            Console.WriteLine(char.ToUpper(a));
            Console.WriteLine(char.IsLower(a));
            Console.WriteLine(char.IsUpper(a));
            Console.WriteLine(char.IsControl(a));
            Console.WriteLine(char.IsDigit(a));
            Console.WriteLine(char.IsPunctuation(a));
            Console.WriteLine(char.IsSymbol(a));
            //caractere escape 
            char linienoua = '\n';
            char citatsimplu = '\'';
            char citatdublu = '\"';
            char bip = '\a';
            char backslash = '\\';
            #endregion
            #region bool
            bool ok = true;
            Console.WriteLine(bool.TrueString);
            Console.WriteLine(bool.FalseString);
            Console.WriteLine(ok);
            
            #endregion
            Console.ReadKey();
        }
    }
}
