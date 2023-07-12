using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TMS.Api.Entities
{
    public class TicketCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TicketCategoryId { get; set; }

        [Precision(18, 2)] 
        public decimal Price{ get; set; }
        
        public string Description { get; set; }

        [ForeignKey("EventId")]
        public int EventId { get; set; }

        public Event Event { get; set; }
    }
}
