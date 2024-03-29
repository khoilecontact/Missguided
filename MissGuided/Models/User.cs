﻿using System;
namespace MissGuided.Models
{
    public class User
    { 
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime DOB { get; set; }
    }

    public class UserResponse
    {
        public User user { get; set; }
    }
}
