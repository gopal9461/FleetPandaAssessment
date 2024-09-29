using Entities.Models;

namespace Service.Contracts
{
    public interface ISyncService
    {
        Task SyncData();

        Task<IEnumerable<Customer>> GetCustomersWithLocationFromLocal();
    }
}
