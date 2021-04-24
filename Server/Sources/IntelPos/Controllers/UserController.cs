using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using IntelPos.Controllers.Models.Input;
using IntelPos.Controllers.Models.Output;
using Microsoft.AspNetCore.Mvc;


namespace IntelPos.Controllers
{
    [ApiController]
    [Route("Users")]
    public class UserController : Controller
    {
        public UserController() { }


        [HttpGet("")]
        public BaseApiResponse<BaseCollectionResponse<User>> GetUsers()
        {
            using var context = new ApplicationContext();
            var users = context.Users.ToList();

            var collectionResponse = new BaseCollectionResponse<User>(users);
            return new BaseApiResponse<BaseCollectionResponse<User>>(200, collectionResponse);
        }

        [HttpPost("")]
        public BaseApiResponse<bool> Register()
        {
            using var context = new ApplicationContext();
            
            var existed = context.Users.Find(Request.Form["Email"]);
            if (existed != default)
            {
                return new BaseApiResponse<bool>(200, false);
            }
            Console.WriteLine(Request.Form["Email"], Request.Form["Password"]);
            context.Users.Add(new User(Request.Form["Email"], Request.Form["Password"]));
            context.SaveChanges();

            return new BaseApiResponse<bool>(200, true);
        }
        
    }
}