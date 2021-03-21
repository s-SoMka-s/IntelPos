using System.ComponentModel.DataAnnotations;

namespace IntelPos
{
    public class Card
    {
        [Key]
        public long Id { get; set; }
    }
}