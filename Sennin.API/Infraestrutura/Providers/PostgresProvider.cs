using Npgsql;
using System.Data;

namespace Sennin.API.Infraestrutura.Providers
{
    public class PostgresProvider : IDbProvider
    {
        public IDbConnection GetDbConnection(string connectionString) => new NpgsqlConnection(connectionString);
    }
}
