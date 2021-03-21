﻿using System.ComponentModel.DataAnnotations;

namespace IntelPos
{
    public class User
    {
        [Key]
        public string Email { get; set; }
        public string Password { get; set; }
        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}