using TMS.Api.DbContext;
using TMS.Api.Entities;

namespace TMS.Api.Repositories
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        public EventRepository(TicketManagementDbContext dbContext) : base(dbContext)
        {

        }
        public Task<bool> IsEventNameAndDateUnique(string name, DateTime eventStartDate, DateTime eventEndDate)
        {
            var matches = _dbContext.Event.Any(e => e.EventName.Equals(name) && e.StartDate.Date.Equals(eventStartDate.Date) && e.EndDate.Equals(eventEndDate.Date));
            return Task.FromResult(matches);
        }
    }
}
