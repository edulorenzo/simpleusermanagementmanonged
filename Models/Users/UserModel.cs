﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simpleusermanagement.Models.Users
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string email { get; set; }
    }
}
