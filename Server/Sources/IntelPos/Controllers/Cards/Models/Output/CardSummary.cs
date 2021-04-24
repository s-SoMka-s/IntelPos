using Newtonsoft.Json;

namespace IntelPos
{
    public class CardSummary
    {
        public CardSummary(Card source)
        {
            this.Id = source.Id;
            this.Term = source.Term;
            this.Definiition = source.Definition;
        }


        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("term")]
        public string Term { get; set; }

        [JsonProperty("definition")]
        public string Definiition { get; set; }
    }
}