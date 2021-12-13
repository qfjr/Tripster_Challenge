using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TripTest.Models;

namespace TripTest.API
{
    public static class TripsterApi
    {
        public static async Task<List<Product>> GetProductsAsync()
        {
            List<Product> products;
                //List<Product> products;
                using (HttpClient client = new HttpClient())
                {
                    string url = @"http://www.tripster.com/api/v3/products?loc=orlando";
                    client.DefaultRequestHeaders.Add("x-api-key", "VOiJVq5BikOHTSZMgFtGFQ");
                    client.DefaultRequestHeaders.Add("Accept", "application/json");
                    HttpResponseMessage response = await client.GetAsync(url);

                    products = await response.Content.ReadAsAsync<List<Product>>();
                }
            
            return products;
        }
    }
}
