using API.Models.Base;
using System.ComponentModel;

namespace API.Models
{
    public class LogradouroRequestModel : BaseRequestModel
    {
        public LogradouroRequestModel() : base()
        {
        }

        public string Cidade { get; set; }
        public string UF { get; set; }

        [DisplayName("Logradouro")]
        public string LogradouroEndereco { get; set; }
        public int Numero { get; set; }
        public int ClienteId { get; set; }
    }
}
