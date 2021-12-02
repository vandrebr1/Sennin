using Sennin.API.Infraestrutura;
using Sennin.API.Model;
namespace Sennin.API.Repository
{
    public class ProdutoMovimentacaoRepository : Repository<ProdutoMovimentacao>
    {
        public ProdutoMovimentacaoRepository(DbSession session) : base(session) { }

    }
}
