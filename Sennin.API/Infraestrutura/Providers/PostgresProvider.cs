using Dapper;
using Npgsql;
using System.Data;

namespace Sennin.API.Infraestrutura.Providers
{
    public class PostgresProvider : IDbProvider
    {
        public PostgresProvider()
        {
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.PostgreSQL);
        }

        public IDbConnection GetDbConnection(string connectionString) => new NpgsqlConnection(connectionString);
    }
}
