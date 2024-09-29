using Entities.Models;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.Dapper.Plus;

namespace Repository
{
    public class ChangeLogRepository: IChangeLogRepository
    {
        private readonly string conString = ConfigurationManager.ConnectionStrings["sqliteCon"].ConnectionString;

        public async Task SaveChangeLogs(IEnumerable<ChangeLog> changes)
        {
            using var con = new SQLiteConnection(conString);
            await con.BulkInsertAsync(changes);
        }
    }
}
