using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IntelPos
{
    public class BoxSummary
    {
        public BoxSummary(Box box)
        {
            this.Id = box.Id;
            this.Name = box.Name;
            this.Cards = box.Cards.Select(c => new CardSummary(c));
        }


        [JsonProperty("id")]
        public long Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cards")]
        public IEnumerable<CardSummary> Cards {get;set;}
    }
}