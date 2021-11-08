using System.ComponentModel.DataAnnotations.Schema;
using Sennin.API.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sennin.API.Model
{
    [Table("empresas")]
    public class Empresa : EntityBase<int>
    {
        public string Nome { get; set; }

    }
}
