using Sennin.API.Infraestrutura;
using Sennin.API.Model;
namespace Sennin.API.Repository
{
    public class PaisRepository : Repository<Pais>
    {
        public PaisRepository(DbSession session) : base(session) { }

    }
}
