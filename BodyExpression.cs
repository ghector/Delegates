using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {

        static void Main(string[] args)
        {
            //Output(50);
            // Output(5000);

            var noumero = MethodA();
            Console.WriteLine(noumero);


            var a = MethodB(5, 7);
            Console.WriteLine(a);

        }

        public static void Output(int a) => Console.WriteLine($"{a:C}");
        public static int MethodA() => 2018 + 2018;
        public static bool MethodB(int a, int b) => a > b;












    }




}
