using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    delegate int Mitsos();

    class A
    {


        static void Main(string[] args)
        {
            // (1)Apli xrisi
            // Mitsos m1 = LAKIS;  // Mitsos m2 = new Mitsos(LAKIS);


            // m1 = TAKIS;

            // m1.Invoke();


            // (2) Multicast Delegate
            Mitsos m1 = ConnectToServer;
            m1 += FindDatabase;
            var result =  m1.Invoke();
            Console.WriteLine(result);

           

        }



        public static int ConnectToServer()
        {
            Console.WriteLine("Connecting to Server...");
            return 200;  //401
         
        }

        public static int FindDatabase()
        {
            Console.WriteLine("Database exists...");
            return 200;  //402

        }
        public static int GetData()
        {
            Console.WriteLine("Table Student loaded...");
            return 200;  //403

        }

        public static int PrintData()
        {
            Console.WriteLine("Print Data..");
            return 200;  //404
        }



    }


    class Tools
    {
        public static void Perifimi(bool isMesaionas)
        {
            if (isMesaionas)
            {
                Console.WriteLine("Einai mesaionaa (((");
            }
            else
            {
                Console.WriteLine("Den einai mesaionas )))");
            }
        }
    }

   













}
