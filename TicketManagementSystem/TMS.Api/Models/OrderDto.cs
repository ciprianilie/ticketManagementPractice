using TMS.Api.Entities;

namespace TMS.Api.Models
{
    public class OrderDto
    {
        public int OrderId { get; set; }

        public decimal TotalPrice { get; set; }

        public int NumberOfTickets { get; set; }

        public DateTime OrderDate { get; set; }

        public int EventId { get; set; }
        
        public Event? Event { get; set; }

        public int TicketCategoryId { get; set; }

        public TicketCategory? TicketCategory { get; set; }

    }
}
