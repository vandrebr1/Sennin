using System.ComponentModel.DataAnnotations.Schema;
using Sennin.API.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sennin.API.Model
{
    [Table("produtos")]
    public class Produto : EntityBase<int>
    {
        public string Nome { get; set; }
        public string Sku { get; set; }
        public string CodBarras { get; set; }

    }
}
