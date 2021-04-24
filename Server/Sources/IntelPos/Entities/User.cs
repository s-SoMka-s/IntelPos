using IntelPos.Entities.BaseDataType;

namespace IntelPos
{
    public class User : BaseDataType
    {
        public User() : base()
        {
            this.Email = string.Empty;
            this.Password = string.Empty;
            this.Name = string.Empty;
        }


        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}