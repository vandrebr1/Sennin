using Sennin.API.Infraestrutura;
using Sennin.API.Model;
using Sennin.API.Repository.Base;
namespace Sennin.API.Repository
{
    public class ClienteRepository : Repository<Cliente>
    {
        public ClienteRepository(DbSession session) : base(session) { }

        

    }
}
