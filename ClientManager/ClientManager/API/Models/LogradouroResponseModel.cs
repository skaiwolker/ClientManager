using API.Models.Base;
using Domain.Entities;
using System.ComponentModel;

namespace API.Models
{
    public class LogradouroResponseModel : BaseResponseModel
    {
        public LogradouroResponseModel() : base()
        {
            Cliente = new();
        }

        public virtual Cliente Cliente { get; set; }

        public string Cidade { get; set; }
        public string UF { get; set; }

        [DisplayName("Logradouro")]
        public string LogradouroEndereco { get; set; }
        public int Numero { get; set; }
        public int ClienteId { get; set; }
    }
}
