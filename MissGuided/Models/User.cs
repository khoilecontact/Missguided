using System;
namespace MissGuided.Models
{
    public class User
    {
        public User()
        {
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
