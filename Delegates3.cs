using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp23
{

    delegate bool DelOnoma(int year);
    delegate bool DelSuccesgulStudent(Student s);

    class A
    {
        static void Main(string[] args)
        {
            DelOnoma d1 = IsMesaionas;
            Tools.Perifimi(2018, d1);

            Student s1 = new Student() { Id = 1, Name = "Hector", Score = 60 };
            Student s2 = new Student() { Id = 2, Name = "Marios", Score = 80 };
            Student s3 = new Student() { Id = 3, Name = "Giorgos", Score = 40};

            List<Student> students = new List<Student>() { s1, s2, s3 };


            DelSuccesgulStudent del1 = IsSuccefull;

            Tools.SuccessfullStudents(students, del1);


        }

        public static bool IsMesaionas(int year)
        {
            return year < 1700;
        }

        public static bool IsSuccefull(Student s)
        {
            return s.Score >= 50;
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

        public static void SuccessfullStudents(List<Student> students,DelSuccesgulStudent isSuccessStudent)
        {
            foreach (var student in students)
            {
                if(isSuccessStudent(student))
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
