using Dapper;
using Entities.Models;
using Repository.Contracts;
using System.Configuration;
using System.Data.SQLite;

namespace Repository
{
    public class CustomerRepositoryLocal : ICustomerRepository
    {
        private readonly string conString = ConfigurationManager.ConnectionStrings["sqliteCon"].ConnectionString;

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            using var con = new SQLiteConnection(conString);
            var sql = "select * from Customer";
            var data = await con.QueryAsync<Customer>(sql);

            return data;
        }

        public async Task<IEnumerable<Customer>> GetCustomersWithLocation()
        {
            using var con = new SQLiteConnection(conString);
            var sql = "select * from Customer c left join Location l on l.CustomerId = c.CustomerId";

            var customerDict = new Dictionary<int, Customer>();
            var customers = await con.QueryAsync<Customer, Location, Customer>(sql, (customer, location) => 
                {
                    if(!customerDict.TryGetValue(customer.CustomerId, out var currentCustomer))
                    {
                        currentCustomer = customer;
                        customerDict.Add(currentCustomer.CustomerId, currentCustomer);
                    }

                    currentCustomer.Locations.Add(location);
                    return currentCustomer;
                },
                splitOn: "LocationId"
            );

            return customers.Distinct().ToList();
        }
    }
}
