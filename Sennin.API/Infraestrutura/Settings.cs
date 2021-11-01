using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sennin.API.Infraestrutura
{
    public static class Settings
    {
        public const string ConnectionString = "Server=localhost;Port=5432;Database=sennin;User Id=postgres;Password=031212; Trust Server Certificate=true;";

        //public const string ConnectionString = "Server=localhost;Port=5432;Database=sennin;User Id=postgres;Password=031212;SSL Mode = Require; Trust Server Certificate=true;";
    }
}
