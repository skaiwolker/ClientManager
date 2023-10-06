using API.Models.Base;
using AutoMapper;
using Domain.Entities.Base;
using Domain.Interfaces.Service.Base;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace API.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<Entity, Request, Response> : Controller where Entity : BaseEntity where Request : BaseRequestModel where Response : BaseResponseModel
    {
        private readonly IService<Entity> _service;
        private readonly IMapper _mapper;

        public BaseController(IService<Entity> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Response>>> GetAll()
        {
            try
            {
                return Ok(_mapper.Map<List<Response>>(await _service.GetAll()));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException?.Message ?? ex.Message);
            }
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<Response>> Get(Guid id)
        {
            try
            {
                return Ok(_mapper.Map<Response>(await _service.GetById(id)));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException?.Message ?? ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Add([FromBody] Request obj)
        {
            try
            {
                await _service.Add(_mapper.Map<Entity>(obj));
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException?.Message ?? ex.Message);
            }
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult> Update([FromBody] Request obj)
        {
            try
            {
                await _service.Update(_mapper.Map<Entity>(obj));
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException?.Message ?? ex.Message);
            }
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                await _service.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException?.Message ?? ex.Message);
            }
        }
    }
}
