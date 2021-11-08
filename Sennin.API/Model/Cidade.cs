using Sennin.API.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sennin.API.Model
{
    [Table("cidades")]
    public class Cidade : EntityBase<int>
    {
        public string Nome { get; set; }

        public int EstadoId { get; set; }
    }
}
