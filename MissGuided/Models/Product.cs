using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MissGuided.Models
{
    //public class Product
    //{
    //    public string[] images { get; set; }
    //    public string name { get; set; }
    //    public string price { get; set; }
    //    public string salePrice { get; set; }
    //    public string[] sizes { get; set; }
    //    public string description { get; set; }
    //    public string[] categories { get; set; }
    //}

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Product
    {
        public string _id { get; set; }
        public List<string> images { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string salePrice { get; set; }
        public List<string> sizes { get; set; }
        public string description { get; set; }
        public List<string> categories { get; set; }
        public int __v { get; set; }
    }

    public class Products
    {
        public List<Product> products { get; set; }
        public List<Product> cart { get; set; }
    }
}

