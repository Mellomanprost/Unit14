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
        }
    }
}
