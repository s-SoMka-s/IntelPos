using Newtonsoft.Json;

namespace IntelPos.Controllers.Models.Input
{
    public class UserInput
    {
        [JsonProperty("Email")]
        public string Email { get; set; }
        [JsonProperty("Password")]
        public string Password { get; set; }
    }
}
