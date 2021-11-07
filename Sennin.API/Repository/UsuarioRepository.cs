using Sennin.API.Infraestrutura;
using Sennin.API.Model;
using Sennin.API.Repository.Base;
namespace Sennin.API.Repository
{
    public class UsuarioRepository : Repository<Usuario>
    {
        public UsuarioRepository(DbSession session) : base(session) { }

    }
}
