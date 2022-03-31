using App.BusinessLayer.Dtos;
using App.DataAccessLayer.Data;
using AutoMapper;

namespace App.BusinessLayer
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserDto, User>();
        }
        
    }
}