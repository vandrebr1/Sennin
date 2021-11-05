using Dapper.Contrib.Extensions;
using Sennin.API.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sennin.API.Model
{
    [Table("clientes")]
    public class Cliente : EmpresaEntity<int>
    {
        public string Nome { get; set; }
        public int BairroId { get; set; }
        public int EnderecoId { get; set; }
        public string EnderecoNumero { get; set; }
    }
}
