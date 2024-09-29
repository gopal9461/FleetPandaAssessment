using Entities.Models;

namespace Repository.Contracts
{
    public interface ISyncRepository
    {
        Task SyncData(IEnumerable<Customer> customers, IEnumerable<Location> locations);
    }
}
