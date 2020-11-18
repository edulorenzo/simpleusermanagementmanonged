using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simpleusermanagement.Entities
{
    public class Login
    {
        public string email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
