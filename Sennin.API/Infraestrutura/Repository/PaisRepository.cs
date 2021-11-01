using Dapper;
using Sennin.API.Infraestrutura.Interfaces;
using Sennin.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sennin.API.Infraestrutura.Repository
{
    public class PaisRepository : IRepository<Pais>
    {
        private DbSession _session;
        private const string tabela = "paises";
        private const string camposSelect = @"id, nome";
        private const string camposInsert = @"id, nome";
        private const string camposInsertValue = @"@Nome";


        public PaisRepository(DbSession session)
        {
            _session = session;
        }

        public IEnumerable<Pais> Get()
        {
            return _session.Connection.Query<Pais>($"SELECT {camposSelect} FROM {tabela}", null, _session.Transaction);
        }


        public void Save(Pais model)
        {
            _session.Connection.Execute($"INSERT INTO {tabela} ({camposInsert}) VALUES({camposInsertValue})", model, _session.Transaction);

        }

    }
}
