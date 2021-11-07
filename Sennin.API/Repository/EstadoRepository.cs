using Sennin.API.Infraestrutura;
using Sennin.API.Model;
using Sennin.API.Repository.Base;
namespace Sennin.API.Repository
{
    public class EstadoRepository : Repository<Estado>
    {
        public EstadoRepository(DbSession session) : base(session) { }

    }
}
