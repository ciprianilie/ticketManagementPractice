using AutoMapper;
using TMS.Api.Entities;

namespace TMS.Api.Profiles
{
    public class VenuesProfile : Profile
    {
        public VenuesProfile()
        {
            CreateMap<Venue, Models.VenueDto>().ReverseMap();
        }
    }
}
