using Sennin.API.Infraestrutura;
using Sennin.API.Model;
using System.Threading.Tasks;

namespace Sennin.API.Repository
{
    public class CidadeRepository : Repository<Cidade>
    {
        public CidadeRepository(DbSession session) : base(session) { }

    }   
}
