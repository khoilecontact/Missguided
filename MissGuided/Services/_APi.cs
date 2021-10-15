//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using MissGuided.Models;
//namespace MissGuided.Services
//{
//    public class _APi
//    {
//        public async Task<List<TodoItem>> RefreshDataAsync()
//        {
//            Uri uri = new Uri(string.Format(Constants.TodoItemsUrl, string.Empty));
//            HttpResponseMessage response = await client.GetAsync(uri);
//            if (response.IsSuccessStatusCode)
//            {
//                string content = await response.Content.ReadAsStringAsync();
//                Items = JsonSerializer.Deserialize<List<TodoItem>>(content, serializerOptions);
//            }
//}
//    }
//}
