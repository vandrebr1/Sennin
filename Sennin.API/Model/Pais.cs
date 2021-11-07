﻿using Dapper.Contrib.Extensions;
using Sennin.API.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sennin.API.Model
{
    [Table("paises")]
    public class Pais : EntityBase<int>
    {
        public string Nome { get; set; }

    }
}
