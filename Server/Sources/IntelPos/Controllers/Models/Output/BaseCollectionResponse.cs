using Newtonsoft.Json;
using System.Collections.Generic;

namespace IntelPos.Controllers.Models.Output
{
    public class BaseCollectionResponse<T>
    {
        public BaseCollectionResponse(List<T> data)
        {
            this.Count = data.Count;
            this.Elements = data;
        }

        [JsonProperty("elements")]
        public List<T> Elements { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }
    }
}
