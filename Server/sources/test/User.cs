using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }
    }
}
