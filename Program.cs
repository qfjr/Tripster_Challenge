using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TripTest.API;
using TripTest.Display;
using TripTest.Models;
using TripTest.Utilities;

namespace TripTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var products = TripsterApi.GetProductsAsync().GetAwaiter().GetResult();
                var sortedProducts = SortDeals.Sort(products);
                ShowDeals.Show(sortedProducts);
            }
            catch(Exception ex)
            {
                // send error to log,email etc
                Console.WriteLine($"There was error when getting the request: " + ex.Message);
            }
        }
    }
}
