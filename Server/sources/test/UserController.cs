using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace test
{
    [ApiController]
    [Route("Users")]
    public class UserController:Controller
    {
        public UserController() { }

        [HttpGet("")]
        public List<User> GetUsers()
        {
            var context = new ApplicationContext();
            var user = context.Users.ToList();
            return user;
        }
        [HttpPost("")]
        public void AddUsers(UserInput parameters)
        {
            var context = new ApplicationContext();
            context.Users.Add(new User(parameters.Name));
            context.SaveChanges();
        }
    }
}
