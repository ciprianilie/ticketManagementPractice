﻿namespace TMS.Api.Models
{
    public class OrderPatchDto
    {
        public int OrderId { get; set; }

        public int NumberOfTickets { get; set; }

        public int TicketCategoryId { get; set; }

    }
}
