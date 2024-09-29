using Entities.Models;
using Repository.Contracts;
using System.Configuration;
using System.Data.SQLite;
using Z.Dapper.Plus;

namespace Repository
{
    public class SyncRepository: ISyncRepository
    {
        private readonly string conString = ConfigurationManager.ConnectionStrings["sqliteCon"].ConnectionString;

        public async Task SyncData(IEnumerable<Customer> customers, IEnumerable<Location> locations)
        {
            using var sqliteCon = new SQLiteConnection(conString);
            await sqliteCon.BulkSynchronizeAsync(customers);
            await sqliteCon.BulkSynchronizeAsync(locations);
        }
    }
}
