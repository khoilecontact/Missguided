using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MissGuided.Models;
using Newtonsoft.Json;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MissGuided.Services
{
    public class CartAPI : ContentPage
    {
        HttpClient client;
        string url = "https://miss-guided-server.herokuapp.com";
        JsonSerializer json_serializer = new JsonSerializer();
        static CartAPI _getService;
        public static CartAPI shared = new CartAPI();
        // GET method
        public static CartAPI getService
        {
            get
            {
                _getService = new CartAPI();
                return _getService;
            }
        }

        public CartAPI()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<bool> AddToCart(string productID)
        {
            try
            {
                string userEmail = Preferences.Get("userEmail", "No email");

                var info = new {
                    productID = productID,
                    email = userEmail
                };

                var content = new StringContent(
                    JsonConvert.SerializeObject(info), Encoding.UTF8, "application/json");

                var response = await client.PostAsync("/user/addToCart", content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                return false;
            }
        }

        public async Task<bool> RemoveFromCart(string productID)
        {
            try
            {
                string userEmail = Preferences.Get("userEmail", "No email");

                var info = new
                {
                    productID = productID,
                    email = userEmail
                };

                var content = new StringContent(
                    JsonConvert.SerializeObject(info), Encoding.UTF8, "application/json");

                var response = await client.PostAsync("/user/removeFromCart", content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                return false;
            }
        }

        public async Task<Products> FetchCart()
        {
            try
            {
                Products products;
                //var content = new StringContent(JsonConvert.SerializeObject(products), Encoding.UTF8, "application/json");
                //string strPage = page.ToString();
                string userEmail = Preferences.Get("userEmail", "No email");
                var response = await client.GetAsync("/user/getCart/"+userEmail);

                response.EnsureSuccessStatusCode();
                using (var stream = await response.Content.ReadAsStreamAsync())
                using (var reader = new StreamReader(stream))
                using (var json = new JsonTextReader(reader))
                {
                    var jsonContent = json_serializer.Deserialize<Products>(json);
                    products = jsonContent;
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
