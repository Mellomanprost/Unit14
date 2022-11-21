using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Unit14._2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            var contacts = new List<Contact>()
            {
                new Contact() { Name = "Андрей", Phone = 7999945005 },
                new Contact() { Name = "Сергей", Phone = 799990455 },
                new Contact() { Name = "Иван", Phone = 79999675 },
                new Contact() { Name = "Игорь", Phone = 8884994 },
                new Contact() { Name = "Анна", Phone = 665565656 },
                new Contact() { Name = "Василий", Phone = 3434 }
            };

            #region MyVariant

            //while (true)
            //{
            //    var keyChar = Console.ReadKey().KeyChar;
            //    Console.Clear();

            //    Console.WriteLine("Введите номер страницы контактов:");
            //    int numberOfPage;
            //    if (int.TryParse(Console.ReadLine(), out numberOfPage))
            //    {
            //        switch (numberOfPage)
            //        {
            //            case 1:
            //                var page1 = contacts.Take(2);
            //                Display(page1);
            //                break;
            //            case 2:
            //                var page2 = contacts.Skip(2).Take(2);
            //                Display(page2);
            //                break;
            //            case 3:
            //                var page3 = contacts.Skip(4).Take(2);
            //                Display(page3);
            //                break;
            //            default:
            //                Console.WriteLine("Введено неверное значение. Допустимые значения: 1, 2, 3");
            //                break;
            //        }
            //    }
            //}

            #endregion


            while (true)
            {
                var keyChar = Console.ReadKey().KeyChar;
                Console.Clear();
                if (!Char.IsDigit(keyChar))
                {
                    Console.WriteLine("Ошибка ввода, введите число");
                }
                else
                {
                    //  переменная для хранения запроса в зависимости от введенного с консоли числа
                    IEnumerable<Contact> page = null;

                    //  выбираем нужное кол-во элементов для создания постраничного ввода в зависимости от запроса
                    switch (keyChar)
                    {
                        case ('1'):
                            page = contacts.Take(2);
                            break;
                        case ('2'):
                            page = contacts.Skip(2).Take(2);
                            break;
                        case ('3'):
                            page = contacts.Skip(4).Take(2);
                            break;
                    }
                    //   проверим, что ввели существующий номер страницы
                    if (page == null)
                    {
                        Console.WriteLine($"Ошибка ввода, страницы {keyChar} не существует");
                        continue;
                    }

                    // вывод результата на консоль
                    foreach (var contact in page)
                        Console.WriteLine(contact.Name + " " + contact.Phone);
                }
            }
        }

        public class Contact
        {
            public string Name;
            public long Phone;
        }

        public static void Display(IEnumerable<Contact> contacts)
        {
            foreach (var cont in contacts)
            {
                Console.WriteLine(cont.Name + " - " + cont.Phone);
            }
        }
    }
}
