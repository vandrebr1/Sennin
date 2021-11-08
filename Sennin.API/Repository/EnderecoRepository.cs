using Sennin.API.Infraestrutura;
using Sennin.API.Model;
namespace Sennin.API.Repository
{
    public class EnderecoRepository : Repository<Endereco>
    {
        public EnderecoRepository(DbSession session) : base(session) { }

    }
}
