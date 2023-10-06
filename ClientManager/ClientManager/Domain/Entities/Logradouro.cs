using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Logradouro : BaseEntity
    {
        public Logradouro() : base()
        {            
        }

        public string Cidade { get; set; }
        public string UF { get; set; }
        public string LogradouroEndereco { get; set; }
        public int Numero { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
