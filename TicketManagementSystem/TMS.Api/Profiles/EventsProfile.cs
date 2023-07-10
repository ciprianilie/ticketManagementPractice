using AutoMapper;
using TMS.Api.Entities;

namespace TMS.Api.Profiles
{
    public class EventsProfile : Profile
    {
        public EventsProfile()
        {
            CreateMap<Event, Models.EventDto>();
        }
    }
}
