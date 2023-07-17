using TMS.Api.Entities;

namespace TMS.Api.Models
{
    public class OrderDto
    {
        public int OrderId { get; set; }

        public decimal TotalPrice { get; set; }

        public int NumberOfTickets { get; set; }

        public DateTime OrderedAt { get; set; }

        public int CustomerId { get; set; }
        
        public Customer? Customer { get; set; }

        public int TicketCategoryId { get; set; }

        public TicketCategory? TicketCategory { get; set; }

    }
}
