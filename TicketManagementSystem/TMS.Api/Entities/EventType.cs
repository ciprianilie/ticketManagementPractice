using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TMS.Api.Entities
{
    public class EventType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventTypeId { get; set; }
        public string EventTypeName { get; set; }
        public ICollection<Event>? Events { get; set; }
    }
}
