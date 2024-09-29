using Entities.Models;

namespace Repository.Contracts
{
    public interface ILocationRepository
    {
        Task<IEnumerable<Location>> GetLocations();
    }
}
