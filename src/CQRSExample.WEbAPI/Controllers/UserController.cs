using CQRSExample.Application.Commands;
using CQRSExample.Application.Queies;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRSExample.WEbAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ISender _sender;
        public UserController(ISender sender)
        {
            _sender = sender;   
        }
        [HttpPost]
        public async Task<ActionResult> CreateUser([FromQuery]CreateUserCommand request)
        {
            var res = await _sender.Send(request);
            return Ok(res);
        }
        [HttpGet]
        public async Task<ActionResult> GetAllUser()
        {
            var query = new GetAllUserQuery();
            var res =  await _sender.Send(query);
            return Ok(res);
        }
    }
}
