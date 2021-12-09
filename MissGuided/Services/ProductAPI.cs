using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MissGuided.Models;
using System.Net.Http.Headers;
using System.Text;
using System.IO;

using Xamarin.Forms;

namespace MissGuided.Services
{
    public class ProductAPI : ContentPage
    {
        HttpClient client;
        string url = "https://miss-guided-server.herokuapp.com";
        JsonSerializer json_serializer = new JsonSerializer();
        static ProductAPI _getService;
        public static ProductAPI shared = new ProductAPI();
        // GET method
        public static ProductAPI getService
        {
            get
            {
                _getService = new ProductAPI();
                return _getService;
            }
        }

        public ProductAPI()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Product>> FetchProducts(int page, string query)
        {
            try
            {


                List<Product> products = new List<Product>();
                //var content = new StringContent(JsonConvert.SerializeObject(products), Encoding.UTF8, "application/json");
                string strPage = page.ToString();
                //string searchQuery = filter.ToString();
                string queryString = "/" + strPage + "?" + query;
                var response = await client.GetAsync("/product" + queryString);

                response.EnsureSuccessStatusCode();
                using (var stream = await response.Content.ReadAsStreamAsync())
                using (var reader = new StreamReader(stream))
                using (var json = new JsonTextReader(reader))
                {
                    var jsonContent = json_serializer.Deserialize<Products>(json);
                    products = jsonContent.products;
                    return products;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                return null;
            }
        }
    }
}

