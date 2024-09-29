using Dapper;
using Entities.Models;
using Microsoft.Data.SqlClient;
using Repository.Contracts;
using System.Configuration;
using System.Data.SQLite;

namespace Repository
{
    public class LocationRepositoryLocal: ILocationRepository
    {
        private readonly string conString = ConfigurationManager.ConnectionStrings["sqliteCon"].ConnectionString;

        public async Task<IEnumerable<Location>> GetLocations()
        {
            using var con = new SQLiteConnection(conString);
            var sql = "select * from Location";
            var data = await con.QueryAsync<Location>(sql);

            return data;
        }
    }
}
