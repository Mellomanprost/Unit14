using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit14_8_
{
    class Program
    {
        static void Main(string[] args)
        {
            var objects = new List<object>()
            {
                1,
                "Сергей ",
                "Андрей ",
                300,
            };

            var names = from obj in objects where obj is string orderby obj select obj;
            foreach (var name in names)
                Console.WriteLine(name);

            Console.WriteLine();
           
            foreach (var name2 in objects.Where(ob => ob is string).OrderBy(ob => ob))
                Console.WriteLine(name2);
        }
    }
}
