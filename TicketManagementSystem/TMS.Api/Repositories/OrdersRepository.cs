using TMS.Api.DbContext;
using TMS.Api.Entities;

namespace TMS.Api.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(TicketManagementDbContext dbContext) : base(dbContext)
        {
        }
    }
}
