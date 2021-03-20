using System.Linq;
using IntelPos.Output;
using Microsoft.AspNetCore.Mvc;

namespace IntelPos
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
        public BaseApiResponse<bool> Register(UserInput parameters)
        {
            using var context = new ApplicationContext();
            
            var existed = context.Users.Find(parameters.Email);
            if (existed != default)
            {
                return new BaseApiResponse<bool>(200, false);
            }

            context.Users.Add(new User(parameters.Email, parameters.Password));
            context.SaveChanges();
            
            return new BaseApiResponse<bool>(200, true);
        }
    }
}
