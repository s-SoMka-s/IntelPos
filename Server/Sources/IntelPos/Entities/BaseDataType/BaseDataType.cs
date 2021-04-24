using System.ComponentModel.DataAnnotations;

namespace IntelPos.Entities.BaseDataType
{
    public class BaseDataType
    {
        public BaseDataType()
        {
            this.Deleted = default;
        }


        [Key]
        public long Id { get; set; }

        public bool Deleted { get; set; }
    }
}
