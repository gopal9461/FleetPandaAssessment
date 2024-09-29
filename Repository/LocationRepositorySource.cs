using Dapper;
using Entities.Models;
using Microsoft.Data.SqlClient;
using Repository.Contracts;
using System.Configuration;

namespace Repository
{
    public class LocationRepositorySource: ILocationRepository
    {
        private readonly string conString = ConfigurationManager.ConnectionStrings["sqlCon"].ConnectionString;

        public async Task<IEnumerable<Location>> GetLocations()
        {
            using var con = new SqlConnection(conString);
            var sql = "select * from Location";
            var data = await con.QueryAsync<Location>(sql);

            return data;
        }
    }
}
