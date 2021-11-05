using Sennin.API.Infraestrutura.Providers;
using System.Data;

namespace Sennin.API.Infraestrutura
{
    public class DbContext
    {
        private IDbProvider _dbProvider;

        public DbContext SetDbProvider(string providerType)
        {
            _dbProvider = providerType switch {
                "Postgres" => _dbProvider = new PostgresProvider(),
                _ => null
            };

            return this;
        }

        public IDbConnection GetDbContext(string connectionString) 
            => _dbProvider.GetDbConnection(connectionString);
    }
}