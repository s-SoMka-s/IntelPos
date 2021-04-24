using IntelPos.Entities.BaseDataType;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntelPos
{
    public class Card : BaseDataType
    {
        public Card() : base() {
            this.Term = string.Empty;
            this.Definition = string.Empty;
            this.Box = default;
        }


        public string Term { get; set; }
        public string Definition { get; set; }

        [ForeignKey(nameof(Box))]
        public long BoxId { get; set; }
        public Box Box { get; set; }
    }
}