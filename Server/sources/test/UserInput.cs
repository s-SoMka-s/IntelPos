using Newtonsoft.Json;

namespace test
{
    public class UserInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
    }
}
