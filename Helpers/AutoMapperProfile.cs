using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//use automapper package to map properties
using AutoMapper;
//use models and entities
using simpleusermanagement.Entities;
using simpleusermanagement.Models.Users;

namespace simpleusermanagement.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //map the living daylight out of them
            CreateMap<User, UserModel>();
            CreateMap<Register, User>(); //rename to RegisterModel later
            CreateMap<UpdateModel, User>();
        }
    }
}
