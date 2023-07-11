using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using TMS.Api.Models;
using TMS.Api.Repositories;

namespace TMS.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VenuesController : ControllerBase
{

    private readonly IVenueRepository _venueRepository;
    private readonly IMapper _mapper;
    public VenuesController(IVenueRepository venueRepository, IMapper mapper)
    {
        _venueRepository = venueRepository ?? throw new ArgumentNullException(nameof(venueRepository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(_mapper));
    }

    [HttpGet(Name = "GetAllVenues")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult<IEnumerable<VenueDto>>> GetAllVenues()
    {
        var venues = await _venueRepository.GetAllAsync();

        return Ok(_mapper.Map<IEnumerable<VenueDto>>(venues));
    }

    [HttpPatch("{id}", Name = "PartiallyUpdateVenue")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult<VenueDto>> PartiallyUpdateVenue(
            int id,
            JsonPatchDocument<VenueDto> venuePatch)
    {
        var venueEntity = await _venueRepository.GetByIdAsync(id);
        if (venueEntity == null)
        {
            return NotFound();
        }

        var venueDto = _mapper.Map<VenueDto>(venueEntity);
        venuePatch.ApplyTo(venueDto);

        if (!TryValidateModel(venueDto))
        {
            return BadRequest(ModelState);
        }
        _mapper.Map(venueDto, venueEntity);

        await _venueRepository.UpdateAsync(venueEntity);
        return NoContent();
    }

    [HttpDelete("{id}", Name = "DeleteVenueById")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> DeleteVenueById(int id)
    {
        var venueDetails = await _venueRepository.GetByIdAsync(id);

        if (venueDetails == null)
        {
            return NotFound();
        }
        await _venueRepository.DeleteAsync(venueDetails);
        return NoContent();
    }
}
