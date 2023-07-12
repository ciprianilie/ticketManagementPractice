using TMS.Api.DbContext;
using TMS.Api.Entities;

namespace TMS.Api.Repositories
{
    public class TicketCategoryRepository : BaseRepository<TicketCategory>, ITicketCategoryRepository
    {
        public TicketCategoryRepository(TicketManagementDbContext dbContext) : base(dbContext)
        {

        }
    }
}
