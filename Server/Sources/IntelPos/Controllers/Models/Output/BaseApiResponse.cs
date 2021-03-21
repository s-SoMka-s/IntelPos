using Newtonsoft.Json;

namespace IntelPos.Controllers.Models.Output
{
    public class BaseApiResponse<T>
    {
        public BaseApiResponse(long code, T data)
        {
            this.Data = data;
            this.StatusCode = code;
        }

        [JsonProperty("status_code")]
        public long StatusCode { get; set; }

        [JsonProperty("data")]
        public T Data { get; set; }
    }
}
