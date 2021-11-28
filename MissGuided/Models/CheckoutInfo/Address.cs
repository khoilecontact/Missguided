using System;
using SQLite;

namespace MissGuided.Models
{
    public class Address
    {
        public Address()
        {
        }

        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string zipCode { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string country { get; set; }
    }
}
