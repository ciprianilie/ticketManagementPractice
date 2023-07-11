using TMS.Api.DbContext;
using TMS.Api.Entities;

namespace TMS.Api.Repositories
{
    public class VenueRepository : BaseRepository<Venue>, IVenueRepository
    {
        public VenueRepository(TicketManagementDbContext dbContext) : base(dbContext)
        {
        }
    }
}
