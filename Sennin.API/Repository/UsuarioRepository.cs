using Sennin.API.Infraestrutura;
using Sennin.API.Model;
namespace Sennin.API.Repository
{
    public class UsuarioRepository : Repository<Usuario>
    {
        public UsuarioRepository(DbSession session) : base(session) { }

    }
}
