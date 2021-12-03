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
            }
            catch (Exception error)
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
                    JsonConvert.SerializeObject(info), Encoding.UTF8, "application/json");

                var response = await client.PostAsync("/me/registerUser", content);
                if (response.IsSuccessStatusCode)
                {
                    Preferences.Set("userEmail", info.email);
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

        public async Task<User> GetUserInfo()
        {
            try
            {
                string email = Preferences.Get("userEmail", "none");

                if (email == "none" || email == null)
                {
                    return null;
                }

                var info = new
                {
                    email
                };

                var content = new StringContent(
                    JsonConvert.SerializeObject(info), Encoding.UTF8, "application/json");

                var response = await client.PostAsync("/user/getInfo", content);
                response.EnsureSuccessStatusCode();

                User currentUser;

                using (var stream = await response.Content.ReadAsStreamAsync())
                using (var reader = new StreamReader(stream))
                using (var json = new JsonTextReader(reader))
                {
                    var jsonContent = json_serializer.Deserialize<UserResponse>(json);
                    currentUser = jsonContent.user;
                    return currentUser;
                } 
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                return null;
            }
        }

        // Wishlist API

        // Get user's wishlist
        public async Task<List<Product>> GetUserWishlist()
        {
            try
            {
                string email = Preferences.Get("userEmail", "none");
                if (email == "none")
                {
                    return new List<Product>();
                }

                var info = new
                {
                    email 
                };

                var content = new StringContent(
                    JsonConvert.SerializeObject(info), Encoding.UTF8, "application/json");

                var response = await client.PostAsync("/wishlist/get", content);
                response.EnsureSuccessStatusCode();

                List<Product> products = new List<Product>();

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

        // Add to wish list 
        public async Task<bool> AddToWishlist(string productId)
        {
            try
            {
                string userEmail = Preferences.Get("userEmail", "none");
                if (userEmail == "none")
                {
                    return false;
                }

                var info = new
                {
                    email = userEmail,
                    productId = productId
                };

                var content = new StringContent(
                        JsonConvert.SerializeObject(info), Encoding.UTF8, "application/json"); ;

                var response = await client.PostAsync("/wishlist/add", content);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                } else
                {
                    return false;
                } 
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                return false;
            }

        }

        // Remove from wishlist
        public async Task<bool> RemoveFromWishlist(string productId)
        {
            try
            {
                string userEmail = Preferences.Get("userEmail", "none");
                if (userEmail == "none")
                {
                    return false;
                }

                var info = new
                {
                    email = userEmail,
                    productId = productId
                };

                var content = new StringContent(
                        JsonConvert.SerializeObject(info), Encoding.UTF8, "application/json"); ;

                var response = await client.PostAsync("/wishlist/remove", content);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                return false;
            }

        }

        // Order history

        public async Task<bool> AddToOrderd(string productId)
        {
            try
            {
                string userEmail = Preferences.Get("userEmail", "none");
                if (userEmail == "none")
                {
                    return false;
                }

                var info = new
                {
                    email = userEmail,
                    productId = productId
                };

                var content = new StringContent(
                        JsonConvert.SerializeObject(info), Encoding.UTF8, "application/json"); ;

                var response = await client.PostAsync("/user/addToOrdered", content);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                return false;
            }

        }

        public async Task<List<Product>> GetOrdered()
        {
            try
            {
                string userEmail = Preferences.Get("userEmail", "none");
                if (userEmail == "none")
                {
                    return new List<Product>();
                }

                List<Product> products = new List<Product>();
                
                var response = await client.GetAsync("/product/getOrder/" + userEmail);

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
