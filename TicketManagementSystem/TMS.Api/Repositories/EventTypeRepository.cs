using TMS.Api.DbContext;
using TMS.Api.Entities;

namespace TMS.Api.Repositories
{
    public class EventTypeRepository : BaseRepository<EventType>, IEventTypeRepository
    {
        public EventTypeRepository(TicketManagementDbContext dbContext) : base(dbContext)
        {
        }
    }
}
