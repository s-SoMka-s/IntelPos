using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace test
{
    public class UserInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
    }
}
