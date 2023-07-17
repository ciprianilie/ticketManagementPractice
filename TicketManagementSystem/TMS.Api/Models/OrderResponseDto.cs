using TMS.Api.Entities;

namespace TMS.Api.Models
{
    public class OrderResponseDto
    {
        public int OrderId { get; set; }

        public decimal TotalPrice { get; set; }

        public int NumberOfTickets { get; set; }

        public DateTime OrderedAt { get; set; }

        public int TicketCategoryId { get; set; }

        public TicketCategory? TicketCategory { get; set; }
    }
}
