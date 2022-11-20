using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit14._1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            var numsList = new List<int[]>()
            {
                new[] {2, 3, 7, 1},
                new[] {45, 17, 88, 0},
                new[] {23, 32, 44, -6},
            };
            //var sortNumList = from nums in numsList
            //    from num in nums
            //    orderby num
            //    select num;
            var sortNumList = numsList.SelectMany(n => n).OrderBy(s => s);
            foreach (var item in sortNumList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
