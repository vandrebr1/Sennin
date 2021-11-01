using Dapper;
using Sennin.API.Infraestrutura.Interfaces;
using Sennin.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sennin.API.Infraestrutura.Repository
{
    public class EstadoRepository : IRepository<Estado>
    {
        private DbSession _session;
        private const string tabela = "estados";
        private const string camposSelect = @"id, nome, sigla, pais_id";
        private const string camposInsert = @"nome, sigla, pais_id";
        private const string camposInsertValues = @"@Nome, @Sigla, @Pais_id";

        public EstadoRepository(DbSession session)
        {
            _session = session;
        }

        public IEnumerable<Estado> Get()
        {
            return _session.Connection.Query<Estado>($"SELECT {camposSelect} FROM {tabela}", null, _session.Transaction);
        }


        public void Save(Estado model)
        {
            _session.Connection.Execute($"INSERT INTO {tabela} ({camposInsert}) VALUES({camposInsertValues})", model, _session.Transaction);

        }

    }
}
