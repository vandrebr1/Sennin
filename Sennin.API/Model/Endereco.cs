using Dapper.Contrib.Extensions;
using Sennin.API.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sennin.API.Model
{
    [Table("enderecos")]
    public class Endereco : AuditEntity<int>
    {
        public string Nome { get; set; }

        public int CidadeId { get; set; }
    }
}
