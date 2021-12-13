using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TripTest.Models;

namespace TripTest.Utilities
{
    public static class SortDeals
    {
        public static List<Product> Sort(List<Product> products)
        {
            return products.OrderByDescending(x => x.Savings).ToList();
        }
    }
}
