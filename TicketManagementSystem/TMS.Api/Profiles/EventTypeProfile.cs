using AutoMapper;
using TMS.Api.Entities;

namespace TMS.Api.Profiles
{
    public class EventTypeProfile : Profile
    {
        public EventTypeProfile()
        {
            CreateMap<EventType, Models.EventTypeDto>();
        }
    }
}
