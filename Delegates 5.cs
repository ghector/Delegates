using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp23
{

    
   


    class A
    {
        static void Main(string[] args)
        {
            Predicate<int> d1 = x => x < 1700;
            Tools.Perifimi(2018, d1);


            Student s1 = new Student() { Id = 1, Name = "Hector", Score = 60 };
            Student s2 = new Student() { Id = 2, Name = "Marios", Score = 80 };
            Student s3 = new Student() { Id = 3, Name = "Giorgos", Score = 40 };

            List<Student> students = new List<Student>() { s1, s2, s3 };
            Func<Student,bool> del1 = s => s.Score >= 50;


            Tools.SuccessfullStudents(students, del1);

            //delegate void Action(int a);
            //Action<int> onoma = Display;
            Action<int> onoma = a => Console.WriteLine("Kalispera" + a);
            onoma(2018);



            //delegate void Action(int a,int b);
            Action<int, int> onoma2 = (a, b) => Console.WriteLine("kalnisonos" + a + b);
            onoma2(2019, 5);

            //delegate int Func();
            Func<int> foo = () => 2018;

            //delegate string Func(int a);
            Func<int, string> loo = a => "Hector";

            //delegate float Func(int a,int b);
            Func<int, int, float> koo = (a, b) => a / b;

            //delegate bool Predicate(Student s);
            //Predicate<Student> moo = (Student s) => s.Score > 50;
            Predicate<Student> moo = s => s.Score > 50;





        }









    }


    class Tools
    {
        public static void Perifimi(int year, Predicate<int> IsMedieval)
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

        public static void SuccessfullStudents(List<Student> students, Func<Student, bool> isSuccessStudent)
        {

            foreach (var student in students)
            {
                if (isSuccessStudent(student))
                {
                    Console.WriteLine(student.Name);
                }
            }
        }


    }


    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
    }















}
