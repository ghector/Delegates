using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    delegate bool DelOnoma(int year);

    class A
    {


        static void Main(string[] args)
        {
            DelOnoma d1 = IsMesaionas;
            Tools.Perifimi(2018, d1);

        }

        public static bool IsMesaionas(int year)
        {
            return year < 1700;
        }



    }


    class Tools
    {
        public static void Perifimi(int year, DelOnoma IsMedieval)
        {
            if (IsMedieval(year))
            {
                Console.WriteLine("Medieval (((");
            }
            else
            {
                Console.WriteLine("Not Medieval )))");
            }
        }
    }















}
