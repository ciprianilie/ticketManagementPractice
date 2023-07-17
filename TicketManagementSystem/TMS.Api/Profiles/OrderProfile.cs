using AutoMapper;
using TMS.Api.Entities;
using TMS.Api.Models;

namespace TMS.Api.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDto>().ReverseMap();

            CreateMap<OrderPatchDto, Order>().ReverseMap();

            CreateMap<Order, OrderResponseDto>().ReverseMap();
        }
    }
}
