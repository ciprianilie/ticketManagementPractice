using TMS.Api.Entities;

namespace TMS.Api.Models
{
    public class EventDto
    {
        public int EventId { get; set; }

        public string EventName { get; set; }

        public string EventDescription { get; set; }

        public EventType EventType { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
