using IntelPos.Entities.BaseDataType;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntelPos
{
    [Table("Boxes")]
    public class Box : BaseDataType
    {
        public Box() : base()
        {
            this.Name = string.Empty;    
        }


        public string Name { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
    }

}