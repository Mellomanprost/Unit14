using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit14
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };

            /// without LINQ
            //// список, куда будем сохранять выборку
            //var orderedList = new List<string>();

            //// пробежимся по массиву и добавим искомое в наш список
            //foreach (string person in people)
            //{
            //    if (person.ToUpper().StartsWith("А"))
            //        orderedList.Add(person);
            //}

            //// отсортируем список
            //orderedList.Sort();
            //foreach (string s in orderedList)
            //    Console.WriteLine(s);

            /// with LINQ
            //var selectedPeople = from p in people // промежуточная переменная p 
            //    where p.StartsWith("А") // фильтрация по условию
            //    orderby p // сортировка по возрастанию (дефолтная)
            //    select p; // выбираем объект и сохраняем в выборку

            //foreach (string s in selectedPeople)
                //Console.WriteLine(s);
            /// with LINQ short
            var selectedPeople = people.Where(p => p.StartsWith("А")).OrderBy(p => p);

            foreach (string s in selectedPeople)
                Console.WriteLine(s);
        }
    }
}
