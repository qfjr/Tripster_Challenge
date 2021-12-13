using System;
using System.Collections.Generic;
using System.Text;
using TripTest.Models;

namespace TripTest.Display
{
    public static class ShowDeals
    {
        public static void Show(List<Product> products)
        {
            Console.WriteLine("Top Travel Deals in Orlando");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            foreach (var sortedSavings in products)
            {
                Console.WriteLine($"{sortedSavings.Name} (You Save {sortedSavings.Savings})");
            }

            Console.ReadKey();
        }
    }
}
