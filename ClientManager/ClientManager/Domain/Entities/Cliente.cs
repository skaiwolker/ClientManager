using Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Domain.Entities
{
    public class Cliente : BaseEntity
    {
        public Cliente() : base()
        {
        }

        public string Nome { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public Blob Logotipo { get; set; }
        public virtual List<Logradouro> Logradouros { get; set; }
    }
}
