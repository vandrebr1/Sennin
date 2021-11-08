using Sennin.API.Infraestrutura;
using Sennin.API.Model;
namespace Sennin.API.Repository
{
    public class EmpresaRepository : Repository<Empresa>
    {
        public EmpresaRepository(DbSession session) : base(session) { }

    }
}
