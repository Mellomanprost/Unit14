using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit14_8_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Region From Start Unit

            //var objects = new List<object>()
            //{
            //    1,
            //    "Сергей ",
            //    "Андрей ",
            //    300,
            //};

            //var names = from obj in objects where obj is string orderby obj select obj;
            //foreach (var name in names)
            //    Console.WriteLine(name);

            //Console.WriteLine();

            //foreach (var name2 in objects.Where(ob => ob is string).OrderBy(ob => ob))
            //    Console.WriteLine(name2);

            #endregion

            #region Region For SikpWhile, TakeWhile

            // Подготовка данных
            var cars = new List<Car>()
            {
                new Car("Suzuki", "JP"),
                new Car("Toyota", "JP"),
                new Car("Opel", "DE"),
                new Car("Kamaz", "RUS"),
                new Car("Lada", "RUS"),
                new Car("Lada", "RUS"),
                new Car("Honda", "JP"),
            };

            Console.WriteLine("Пропустим японские машины в начале списка");
            var notJapanCars = cars.SkipWhile(car => car.CountryCode == "JP");

            foreach (var notJapanCar in notJapanCars)
                Console.WriteLine(notJapanCar.Manufacturer);

            Console.WriteLine();

            Console.WriteLine("Теперь выберем только японские машины из начала списка");
            var japanCars = cars.TakeWhile(car => car.CountryCode == "JP");

            foreach (var japanCar in japanCars)
                Console.WriteLine(japanCar.Manufacturer);

            #endregion
        }

        public class Car
        {
            public string Manufacturer { get; set; }
            public string CountryCode { get; set; }

            public Car(string manufacturer, string countryCode)
            {
                Manufacturer = manufacturer;
                CountryCode = countryCode;
            }
        }
    }
}
