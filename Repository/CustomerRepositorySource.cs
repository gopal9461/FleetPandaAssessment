using System.Configuration;
using Dapper;
using Entities.Models;
using Microsoft.Data.SqlClient;
using Repository.Contracts;

namespace Repository;

public class CustomerRepositorySource: ICustomerRepository
{
    private readonly string conString = ConfigurationManager.ConnectionStrings["sqlCon"].ConnectionString;
    
    public async Task<IEnumerable<Customer>> GetCustomers()
    {
        using var con = new SqlConnection(conString);
        var sql = "select * from Customer";
        var data = await con.QueryAsync<Customer>(sql);

        return data;
    }

    public async Task<IEnumerable<Customer>> GetCustomersWithLocation()
    {
        using var con = new SqlConnection(conString);
        var sql = "select * from Customer c left join Location l on l.CustomerId = c.CustomerId";

        var customerDict = new Dictionary<int, Customer>();
        var customers = await con.QueryAsync<Customer, Location, Customer>(sql, (customer, location) =>
        {
            if (!customerDict.TryGetValue(customer.CustomerId, out var currentCustomer))
            {
                currentCustomer = customer;
                customerDict.Add(currentCustomer.CustomerId, currentCustomer);
            }

            currentCustomer.Locations.Add(location);
            return currentCustomer;
        });

        return customers.Distinct().ToList();
    }
}
