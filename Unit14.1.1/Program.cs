using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit14._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Добавим Россию с её городами
            var russianCities = new List<City>();
            russianCities.Add(new City("Москва", 11900000));
            russianCities.Add(new City("Санкт-Петербург", 4991000));
            russianCities.Add(new City("Волгоград", 1099000));
            russianCities.Add(new City("Казань", 1169000));
            russianCities.Add(new City("Севастополь", 449138));
            russianCities.Add(new City("Красноярск", 958012));

            var bigCities = from russianCity in russianCities
                where russianCity.Population > 1000000
                orderby russianCity.Population descending
                select russianCity;

            foreach (var bigCity in bigCities)
                Console.WriteLine(bigCity.Name + " - " + bigCity.Population);

            Console.WriteLine();

            foreach (var city in russianCities.Where(c => c.Name.Length <= 10).OrderBy(c => c.Name.Length))
            {
                Console.WriteLine(city.Name + " : " + city.Population);
            }
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
    }
}
