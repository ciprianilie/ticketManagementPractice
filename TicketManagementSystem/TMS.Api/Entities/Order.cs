using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TMS.Api.Entities
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [Precision(18, 2)] 
        public decimal TotalPrice{ get; set; }

        public int NumberOfTickets { get; set; }
        
        public DateTime OrderedAt { get; set; }
        
        [ForeignKey("TicketCategoryId")]
        public int TicketCategoryId { get; set; }

        public TicketCategory TicketCategory { get; set; }

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
