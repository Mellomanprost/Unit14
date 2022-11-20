using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Unit14._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = { "Раз два три",
                "четыре пять шесть",
                "семь восемь девять" };

            var sequence = from str in text
                from word in str.Split(' ')
                select word;

            foreach (var item in sequence)
            {
                Console.WriteLine(item + ", ");
            }
        }
    }
}
