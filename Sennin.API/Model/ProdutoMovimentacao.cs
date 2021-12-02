using System.ComponentModel.DataAnnotations.Schema;
using Sennin.API.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sennin.API.Model
{
    [Table("produtosmovimentacoes")]
    public class ProdutoMovimentacao : EntityBase<int>
    {
        public Produto Produto { get; set; }
        public string Tipo { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Valor { get; set; }

    }
}
