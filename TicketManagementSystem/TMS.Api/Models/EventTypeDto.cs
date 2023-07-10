using TMS.Api.Entities;

namespace TMS.Api.Models
{
    public class EventTypeDto
    {
        public int EventTypeId { get; set; }
        public string EventTypeName { get; set; }
        public ICollection<Event>? Events { get; set; }
    }
}
