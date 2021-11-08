using Sennin.API.Infraestrutura;
using Sennin.API.Model;
namespace Sennin.API.Repository
{
    public class ClienteRepository : Repository<Cliente>
    {
        public ClienteRepository(DbSession session) : base(session) { }

        

    }
}
