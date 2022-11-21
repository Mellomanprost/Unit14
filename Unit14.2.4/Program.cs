using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit14._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Список студентов
            var students = new List<Student>
            {
                new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
                new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }}
            };

            // Список курсов
            var courses = new List<Course>
            {
                new Course {Name="Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
                new Course {Name="Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
            };

            //Добавление студентов младше 29 лет, владеющих английским языком, в курс «Язык программирования C#»
            var studentsCSharp = from s in students
                                 where s.Age < 29 && s.Languages.Contains("английский")
                                 let birthYear = DateTime.Now.Year - s.Age
                                 from c in courses
                                 where c.Name.Contains("Язык программирования C#")
                                 select new
                                 {
                                     Name = s.Name,
                                     YearOfBirth = birthYear,
                                     CourseName = c.Name
                                 };

            foreach (var student in studentsCSharp)
            {
                Console.WriteLine(student.Name + " " + student.YearOfBirth + " - " + student.CourseName);
            }
        }

        public class Student
        {
            public string Name;
            public int Age;
            public List<string> Languages;
        }

        public class Course
        {
            public string Name;
            public DateTime StartDate;
        }

    }
}
