using Sennin.API.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sennin.API.Model
{

    [Table("bairros")]
    public class Bairro : EntityBase<int>
    {
        public string Nome { get; set; }

        public int CidadeId { get; set; }
    }
}
