using TMS.Api.Entities;

namespace TMS.Api.Repositories
{
    public interface IEventRepository : IAsyncRepository<Event>
    {
        Task<bool> IsEventNameAndDateUnique(string name, DateTime eventStartDate, DateTime eventEndDate);
    }
}
