using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//add this for required fields
using System.ComponentModel.DataAnnotations;

namespace simpleusermanagement.Models.Users
{
    public class Register
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
        [Required]
        public string email { get; set; }
    }
}
