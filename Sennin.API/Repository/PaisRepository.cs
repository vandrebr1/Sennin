using Sennin.API.Infraestrutura;
using Sennin.API.Model;
using Sennin.API.Repository.Base;
namespace Sennin.API.Repository
{
    public class PaisRepository : Repository<Pais>
    {
        public PaisRepository(DbSession session) : base(session) { }

    }
}
