using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Forum.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        protected IMediator _mediator;

        public BaseApiController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}