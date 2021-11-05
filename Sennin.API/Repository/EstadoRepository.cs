using Sennin.API.Infraestrutura;
using Sennin.API.Model;

namespace Sennin.API.Repository
{
    public class EstadoRepository : Repository<Estado>
    {
        public EstadoRepository(DbSession session) : base(session) { }

    }
}
