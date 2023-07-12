using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using TMS.Api.Models;
using TMS.Api.Repositories;

namespace TMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;
        private readonly ITicketCategoryRepository _ticketCategoryRepository;
        private readonly IEventRepository _eventRepository;
        private readonly IEventTypeRepository _eventTypeRepository;
        private readonly IVenueRepository _venueRepository;

        public OrdersController(IOrderRepository orderRepository, ITicketCategoryRepository ticketCategoryRepository, IEventRepository eventRepository, IVenueRepository venueRepository, IEventTypeRepository eventTypeRepository, IMapper mapper)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _ticketCategoryRepository = ticketCategoryRepository ?? throw new ArgumentNullException(nameof(ticketCategoryRepository));
            _eventRepository = eventRepository?? throw new ArgumentNullException(nameof(eventRepository));
            _venueRepository = venueRepository ?? throw new ArgumentNullException(nameof(venueRepository));
            _eventTypeRepository = eventTypeRepository ?? throw new ArgumentNullException(nameof(eventTypeRepository));

            _mapper = mapper ?? throw new ArgumentNullException(nameof(_mapper));
        }

        [HttpGet]
        [ProducesResponseType(typeof(OrderDto), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<OrderDto>>> GetOrders()
        {
            //var orders = await _orderRepository.GetAll().Include(d => d.TicketCategory).ThenInclude(d => d.Event).ToListAsync();
            var orders = await _orderRepository.GetAllAsync();
            await _ticketCategoryRepository.GetAllAsync();
            await _eventRepository.GetAllAsync();
            await _venueRepository.GetAllAsync();
            await _eventTypeRepository.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<OrderDto>>(orders));
        }

        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<OrderDto>> Patch(OrderPatchDto orderPatch)
        {
            var orderEntity = await _orderRepository.GetByIdAsync(orderPatch.OrderId);

            await _eventRepository.GetAllAsync();
            await _eventTypeRepository.GetAllAsync();
            await _venueRepository.GetAllAsync();

            var ticketCategoryEntity = await _ticketCategoryRepository.GetByIdAsync(orderPatch.TicketCategoryId);

            if (orderEntity == null || ticketCategoryEntity == null)
            {
                return NotFound();
            }

            orderEntity.NumberOfTickets = orderPatch.NumberOfTickets;
            orderEntity.TicketCategoryId = orderPatch.TicketCategoryId;
            orderEntity.TotalPrice = orderPatch.NumberOfTickets * ticketCategoryEntity.Price;

            _mapper.Map(orderPatch, orderEntity);

            await _orderRepository.UpdateAsync(orderEntity);

            var orderResponse =_mapper.Map<OrderResponseDto>(orderEntity);

            return new ContentResult()
            {
                Content = JsonSerializer.Serialize(orderResponse),
                ContentType = "application/json",
                StatusCode = StatusCodes.Status200OK
            };
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            var order = await _orderRepository.GetByIdAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            await _orderRepository.DeleteAsync(order);

            return new ContentResult()
            {
                Content = id.ToString(),
                ContentType = "application/json",
                StatusCode = StatusCodes.Status200OK
            };
        }
    }
}
