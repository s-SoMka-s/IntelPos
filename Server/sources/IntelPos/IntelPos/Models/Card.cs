using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IntelPos.Models
{
    [Table("Cards")]
    public class Card
    {
        [Key]
        public long Id { get; set; }
        public string Term { get; set; }
        public string Definition { get; set; }
    }
}
