using AutoMapper;
using Reactivities.Domain;

namespace Reactivities.Application.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Activity, Activity>();
        }
    }
}