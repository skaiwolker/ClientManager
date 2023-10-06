using API.Controllers.Base;
using API.Models;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Service;

namespace API.Controllers
{
    public class UserController : BaseController<User, UserRequestModel, UserResponseModel>
    {
        public UserController(IUserService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
