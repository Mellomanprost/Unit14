using System;
using System.Linq;

namespace Unit14._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };
            var sortWords = words.Select(s => new
            {
                AnimalType = s
            }).OrderBy(s => s.AnimalType.Length);
            foreach (var word in sortWords)
            {
                Console.WriteLine(word.AnimalType);
            }


            // Переменные в запросах, let

            //var fullNameStudents = from s in students
            //    // временная переменная для генерации полного имени
            //    let fullName = s.Name + " Иванов"
            //    // проекция в новую сущность с использованием новой переменной
            //    select new
            //    {
            //        Name = fullName,
            //        Age = s.Age
            //    };

            //foreach (var stud in fullNameStudents)
            //    Console.WriteLine(stud.Name + ", " + stud.Age);
        }
    }
}
