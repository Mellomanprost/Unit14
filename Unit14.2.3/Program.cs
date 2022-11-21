using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit14._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Наш список студентов
            List<Student> students = new List<Student>
            {
                new Student { Name = "Андрей", Age = 23, Languages = new List<string> { "английский", "немецкий" } },
                new Student { Name = "Сергей", Age = 27, Languages = new List<string> { "английский", "французский" } },
                new Student { Name = "Дмитрий", Age = 29, Languages = new List<string> { "английский", "испанский" } },
                new Student { Name = "Василий", Age = 24, Languages = new List<string> { "испанский", "немецкий" } }
            };

            // мой вариант кода

            var aplications = students.Select(s => s)
                .Where(s => s.Age < 27)
                .Select(s => new Application()
            {
                Name = s.Name,
                YearOfBirth = DateTime.Now.Year - s.Age
            });
            foreach (var app in aplications)
            {
                Console.WriteLine(app.Name + " " + app.YearOfBirth);
            }

            Console.WriteLine();

            // вариант ответа SkillFactory

            var youngStudentApplications = from s in students
                where s.Age < 27 // берем тех, кто младше 27
                let birthYear = DateTime.Now.Year - s.Age // Вычисляем год рождения
                select new Application() // создаем анкеты
                {
                    Name = s.Name,
                    YearOfBirth = birthYear
                };
            foreach (var studApplication in youngStudentApplications)
                Console.WriteLine(studApplication.Name + ", " + studApplication.YearOfBirth);
        }

        public class Student
        {
            public string Name;
            public int Age;
            public List<string> Languages;
        }
        public class Application
        {
            public string Name { get; set; }
            public int YearOfBirth { get; set; }
        }
    }
}
