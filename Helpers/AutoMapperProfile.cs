using AutoMapper;
using ProiectExamen.Entities;
using ProiectExamen.Models.Users;

namespace ProiectExamen.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<RegisterModel, User>();
            CreateMap<UpdateModel, User>();
        }
    }
}