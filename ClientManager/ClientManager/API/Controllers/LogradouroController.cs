using API.Controllers.Base;
using API.Models;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Service;

namespace API.Controllers
{
    public class LogradouroController : BaseController<Logradouro, LogradouroRequestModel, LogradouroResponseModel>
    {
        public LogradouroController(ILogradouroService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
