using System.Data;

namespace Sennin.API.Infraestrutura.Providers
{
    interface IDbProvider
    {
        IDbConnection GetDbConnection(string connectionString);
    }
}
