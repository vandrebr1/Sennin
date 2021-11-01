namespace Sennin.API.Model
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Sigla { get; set; }

        public int Pais_id { get; set; }

        public virtual Pais Pais { get; set; }

    }
}
