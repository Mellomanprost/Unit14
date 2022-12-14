using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit14._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Unit14.1.1 part1

            //// Добавим Россию с её городами
            //var russianCities = new List<City>();
            //russianCities.Add(new City("Москва", 11900000));
            //russianCities.Add(new City("Санкт-Петербург", 4991000));
            //russianCities.Add(new City("Волгоград", 1099000));
            //russianCities.Add(new City("Казань", 1169000));
            //russianCities.Add(new City("Севастополь", 449138));
            //russianCities.Add(new City("Красноярск", 958012));

            //var bigCities = from russianCity in russianCities
            //    where russianCity.Population > 1000000
            //    orderby russianCity.Population descending
            //    select russianCity;

            //foreach (var bigCity in bigCities)
            //    Console.WriteLine(bigCity.Name + " - " + bigCity.Population);

            //Console.WriteLine();

            //foreach (var city in russianCities.Where(c => c.Name.Length <= 10).OrderBy(c => c.Name.Length))
            //{
            //    Console.WriteLine(city.Name + " : " + city.Population);
            //}


            #endregion

            #region Unit14.1.1 part2

            //// Словарь для хранения стран с городами
            //var Countries = new Dictionary<string, List<City>>();

            //// Добавим Россию с её городами
            //var russianCities = new List<City>();
            //russianCities.Add(new City("Москва", 11900000));
            //russianCities.Add(new City("Санкт-Петербург", 4991000));
            //russianCities.Add(new City("Волгоград", 1099000));
            //russianCities.Add(new City("Казань", 1169000));
            //russianCities.Add(new City("Севастополь", 449138));
            //Countries.Add("Россия", russianCities);

            //// Добавим Беларусь
            //var belarusCities = new List<City>();
            //belarusCities.Add(new City("Минск", 1200000));
            //belarusCities.Add(new City("Витебск", 362466));
            //belarusCities.Add(new City("Гродно", 368710));
            //Countries.Add("Беларусь", belarusCities);

            //// Добавим США
            //var americanCities = new List<City>();
            //americanCities.Add(new City("Нью-Йорк", 8399000));
            //americanCities.Add(new City("Вашингтон", 705749));
            //americanCities.Add(new City("Альбукерке", 560218));
            //Countries.Add("США", americanCities);

            //// Выборка городов-миллионников
            //var cities = from country in Countries // пройдемся по странам
            //    from city in country.Value // пройдемся по городам
            //    where city.Population > 1000000 // выберем города - миллионники
            //    orderby city.Population descending // отсортируем по населению
            //    select city;

            //foreach (var city in cities)
            //    Console.WriteLine(city.Name + " - " + city.Population);


            #endregion

            #region Unit14.1.1 part3

            // Подготовим данные
            List<Student> students = new List<Student>
            {
                new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
                new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
                new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };

            // Составим запрос ()
            var selectedStudents = students.SelectMany(
                    // коллекция, которую нужно преобразовать
                    s => s.Languages,
                    // функция преобразования, применяющаяся к каждому элементу коллекции
                    (s, l) => new { Student = s, Lang = l })
                // дополнительные условия                          
                .Where(s => s.Lang == "английский" && s.Student.Age < 28)
                // указатель на объект выборки
                .Select(s => s.Student);

            // Выведем результат
            foreach (Student student in selectedStudents)
                Console.WriteLine($"{student.Name} - {student.Age}");

            #endregion
        }

        // Создадим модель класс для города
        public class City
        {
            public City(string name, long population)
            {
                Name = name;
                Population = population;
            }

            public string Name { get; set; }
            public long Population { get; set; }
        }

        // Создадим модель класс для студента
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public List<string> Languages { get; set; }
        }
    }
}
