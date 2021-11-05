using Sennin.API.Model.Base;

namespace Sennin.API.Model
{
    public class Estado : AuditEntity<int>
    {
        public string Nome { get; set; }

        public string Sigla { get; set; }

        public int PaisId { get; set; }

    }
}
