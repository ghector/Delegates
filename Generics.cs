using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Generics
    {

        static void Main(string[] args)
        {
            //Person p1 = new Person();
            //Person p2 = new Person();
            //
            //p1 = p2;
            //var result = Tools.Compare(5, p1);
            //Console.WriteLine(result);
            //
            //Tools.Ektiposi(p1, 2018, p1);


            LIST<int> l1 = new LIST<int>();
          
        }

    }

    class LIST <T> where T:struct
    {
        public static void Output(T a, T b)
        {
            Console.WriteLine(ab );
        }
    }











    class Tools
    {
        public static bool Compare<T>(T a,T b) where T:class
        {
            return a.Equals(b);
        }

        public static bool Compare<T1, T2>(T1 a, T2 b) where T1 : struct where T2 : class
        {
            return a.Equals(b);
        }




        public static void Ektiposi<T1, T2, T3>(T1 a, T2 b, T3 c)
        {
            Console.WriteLine($"{a} ### {b} ### {c}");
        }

    }

    class Person
    {
       
    }




}
