using API.Models.Base;
using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace API.Models
{
    public class ClienteResponseModel : BaseResponseModel
    {
        public ClienteResponseModel() : base()
        {
            Logradouros = new();
        }

        public virtual List<Logradouro> Logradouros { get; set; }

        public string Nome { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public Blob Logotipo { get; set; }
    }
}
