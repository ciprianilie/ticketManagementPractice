using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TMS.Api.Entities
{
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventId { get; set; }

        [Required]
        [MaxLength(50)]
        public string EventName { get; set; }
        
        [MaxLength(200)]
        public string EventDescription { get; set; }
        
        public DateTime StartDate { get; set; }
        
        public DateTime EndDate { get; set; }

        [ForeignKey("EventTypeId")]
        public int EventTypeId { get; set; }

        public EventType EventType { get; set; }

        [ForeignKey("VenueId")]
        public int VenueId { get; set; }

        public Venue Venue { get; set; }

    }
}
