using Entities.Models;

namespace Repository.Contracts
{
    public interface IChangeLogRepository
    {
        Task SaveChangeLogs(IEnumerable<ChangeLog> changes);
    }
}
