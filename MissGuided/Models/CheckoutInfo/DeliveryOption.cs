using System;
using SQLite;

namespace MissGuided.Models.CheckoutInfo
{
    public class DeliveryOption
    {
        public DeliveryOption()
        {
        }

        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string name { get; set; }
        public string price { get; set; }
    }
}
