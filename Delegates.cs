using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    delegate void Mitsos();

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
            m1 += GetData;
            m1 += PrintData;
         

            m1.Invoke();

        }



        public static void ConnectToServer()
        {
            Console.WriteLine("Connecting to Server...");
            Thread.Sleep(3000);
        }

        public static void FindDatabase()
        {
            Console.WriteLine("Database exists...");
            Thread.Sleep(1000);
        }
        public static void GetData()
        {
            Console.WriteLine("Table Student loaded...");
            Thread.Sleep(2000);
        }

        public static void PrintData()
        {
            Console.WriteLine("Print Data..");
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
