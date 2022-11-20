using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit14._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, string[]>();

            companies.Add("Apple", new[] { "Mobile", "Desktop" });
            companies.Add("Samsung", new[] { "Mobile" });
            companies.Add("IBM", new[] { "Desktop" });

            var mobComp = companies.Where(c => c.Value.Contains("Mobile"));

            foreach (var item in mobComp)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
