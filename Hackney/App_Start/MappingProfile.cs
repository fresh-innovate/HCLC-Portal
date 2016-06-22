using AutoMapper;
using Hackney.Controllers.Dtos;
using Hackney.Core.Models;

namespace Hackney
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<ApplicationUser, UserDto>();
            Mapper.CreateMap<Notification, NotificationDto>();
        }

        protected override void Configure()
        {

        }
    }
}