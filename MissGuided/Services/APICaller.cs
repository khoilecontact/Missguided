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
using Xamarin.Essentials;

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

        public async Task<List<Product>> FetchProductsSwipe(int page)
        {
            try
            {
                List<Product> products = new List<Product>();
                //var content = new StringContent(JsonConvert.SerializeObject(products), Encoding.UTF8, "application/json");
                string strPage = page.ToString();
                var response = await client.GetAsync("/product/swipe/" + strPage);

                response.EnsureSuccessStatusCode();
                using (var stream = await response.Content.ReadAsStreamAsync())
                using (var reader = new StreamReader(stream))
                using (var json = new JsonTextReader(reader))
                {
                    var jsonContent = json_serializer.Deserialize<Products>(json);
                    products = jsonContent.products;
                    return products;
                }
            } catch(Exception error)
            {
                Console.WriteLine(error);
                return null;
            }
        }

        public async Task<bool> Login(string email, string password)
        {
            try
            {
                var info = new
                {
                    email = email,
                    password = password
                };

                var content = new StringContent(
                    JsonConvert.SerializeObject(info), Encoding.UTF8, "application/json");

                var response = await client.PostAsync("/me/loginUser", content);
                if (response.IsSuccessStatusCode)
                {
                    Preferences.Set("userEmail", email);
                    return true;
                } else
                {
                    return false;
                }
            } catch(Exception error)
            {
                Console.WriteLine(error);
                return false;
            }
        }

        public async Task<bool> Register(string firstName, string lastName, string email, string password)
        {
            try
            {
                var info = new
                {
                    firstName = firstName,
                    lastName = lastName,
                    email = email,
                    password = password
                };

                var content = new StringContent(
                    JsonConvert.SerializeObject(info), Encoding.UTF8, "application/json");;

                var response = await client.PostAsync("/me/registerUser", content);
                if (response.IsSuccessStatusCode)
                {
                    Preferences.Set("userEmail", email);
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
    }

    
}
