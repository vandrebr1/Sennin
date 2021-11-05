using System;
using System.Data;

namespace Sennin.API.Infraestrutura
{

    public sealed class DbSession : IDisposable
    {
        private Guid _id;
        public IDbConnection Connection { get; }
        public IDbTransaction Transaction { get; set; }

        public DbSession(DatabaseOptions dbOptions)
        {
            _id = Guid.NewGuid();
            var dbContext = new DbContext().SetDbProvider(dbOptions.ProviderName);
            Connection = dbContext.GetDbContext(dbOptions.ConnectionString);
            Connection.Open();
        }

        public void Dispose() => Connection?.Dispose();
    }

}
