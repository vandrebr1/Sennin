using Dapper;
using Sennin.API.Model.Base;

namespace Sennin.API.Model
{
    [Table("enderecos")]
    public class Estado : EntityBase<int>
    {
        public string Nome { get; set; }

        public string Sigla { get; set; }

        public int PaisId { get; set; }

    }
}
