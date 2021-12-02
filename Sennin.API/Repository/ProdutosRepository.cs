using Sennin.API.Infraestrutura;
using Sennin.API.Model;
namespace Sennin.API.Repository
{
    public class ProdutosRepository : Repository<Produto>
    {
        public ProdutosRepository(DbSession session) : base(session) { }

    }
}
