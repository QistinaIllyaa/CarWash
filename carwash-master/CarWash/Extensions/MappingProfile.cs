using AutoMapper;
using CarWash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRegistrationModel, User>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));

            //CreateMap<StaffRegistration, User>()
            //    .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }

    }
}
