using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TMS.Api.Models;
using TMS.Api.Repositories;

namespace TMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventRepository _eventRepository;
        private readonly IEventTypeRepository _eventTypeRepository;
        private readonly IMapper _mapper;

        public EventsController(IEventRepository eventRepository, IEventTypeRepository eventTypeRepository, IMapper mapper)
        {
            _eventRepository = eventRepository ?? throw new ArgumentNullException(nameof(eventRepository));
            _eventTypeRepository = eventTypeRepository ?? throw new ArgumentNullException(nameof(eventTypeRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(_mapper));
        }

        [HttpGet(Name = "GetAllEvents")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<IEnumerable<EventDto>>> GetEvents()
        {
            var events = await _eventRepository.GetAllAsync();

            // TODO: Populate Venue and Event Type

            return Ok(_mapper.Map<IEnumerable<EventDto>>(events));
        }

        [HttpGet("{id}", Name = "GetEventById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<EventDto>> GetEventById(int id)
        {
            var eventDetails = await _eventRepository.GetByIdAsync(id);
            var eventDetailDto = _mapper.Map<EventDto>(eventDetails);

            if (eventDetailDto == null)
            {
                return NotFound();
            }

            // TODO: Populate Venue and Event Type

            return Ok(_mapper.Map<EventDto>(eventDetails));
        }
    }
}
