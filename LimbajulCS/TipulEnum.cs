using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimbajulCS
{
    class TipulEnum
    {
        enum EmpType
        {
            Manager, // = 0
            Grunt, // = 1
            Contractor, // = 2
            VicePresident // = 3
        }
        enum Culori
        {
            Rosu = 20,
            Galben=3,
            Albastru=4,
            Mov =78
        }
        enum   ghiozdane : byte
        {
            Herlitz =3,
            Nike =100
        }

        static void Main()
        {
            
            EmpType e = EmpType.Contractor;
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    break;
            }

            return;
        }
    }
}
