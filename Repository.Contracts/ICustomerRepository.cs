using Entities.Models;

namespace Repository.Contracts
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetCustomers();

        Task<IEnumerable<Customer>> GetCustomersWithLocation();
    }
}
