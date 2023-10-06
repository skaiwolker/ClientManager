using API.Controllers.Base;
using API.Models;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ClienteController : BaseController<Cliente, ClienteRequestModel, ClienteResponseModel>
    {
        public ClienteController(IClienteService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
