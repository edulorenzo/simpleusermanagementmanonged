using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simpleusermanagement.Models.Users
{
    public class UpdateModel
    {
        //should I allow updating of all fields?
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string email { get; set; }
    }
}
