using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }

    }
}
