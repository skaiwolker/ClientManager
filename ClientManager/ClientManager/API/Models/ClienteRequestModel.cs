using API.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace API.Models
{
    public class ClienteRequestModel : BaseRequestModel
    {
        public ClienteRequestModel() : base()
        {
        }

        public string Nome { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public Blob Logotipo { get; set; }

    }
}
