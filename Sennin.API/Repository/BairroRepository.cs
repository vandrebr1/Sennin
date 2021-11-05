using Sennin.API.Infraestrutura;
using Sennin.API.Model;

namespace Sennin.API.Repository
{
    public class BairroRepository : Repository<Bairro>
    {
        public BairroRepository(DbSession session) : base(session) { }

    }
}
