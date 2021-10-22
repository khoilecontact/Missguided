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

namespace MissGuided
{
    public class APICaller: IRestService
    {
        HttpClient client;
        string url = "https://miss-guided-server.herokuapp.com";
        JsonSerializer json_serializer = new JsonSerializer();
        static APICaller _getService;
        public static APICaller shared = new APICaller();
        // GET method
        public static APICaller getService
        {
            get
            {
                _getService = new APICaller();
                return _getService;
            }
        }

        public APICaller()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Product>> FetchProducts()
        {
            try
            {
                List<Product> products = new List<Product>();
                //var content = new StringContent(JsonConvert.SerializeObject(products), Encoding.UTF8, "application/json");
                var response = await client.GetAsync("/product/1");

                response.EnsureSuccessStatusCode();
                using (var stream = await response.Content.ReadAsStreamAsync())
                using (var reader = new StreamReader(stream))
                using (var json = new JsonTextReader(reader))
                {
                    var jsonContent = json_serializer.Deserialize<Products>(json);
                    products = jsonContent.products;
                    return products;
                }

                return products;
            } catch(Exception error)
            {
                Console.WriteLine(error);
                return null;
            }
        }
    }

    
}
