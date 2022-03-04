using Forum.Application.Commands.Activities;
using Forum.Application.DTOs.Activity;
using Forum.Application.Queries.Activities;
using Forum.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController : BaseApiController
    {
        #region ctor
        public ActivitiesController(IMediator mediator):base(mediator)
        {
            
        }
        #endregion
        #region methods

        [HttpGet]
        public async Task<IActionResult> GetAll() {
            return Ok(await _mediator.Send(new getListActivities()));
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(Guid Id) {
            return Ok(await _mediator.Send(new getActivityById(Id)));
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Activity activity) {
            return Ok(await _mediator.Send(new CreateActivity(activity)));
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ActivityDTO activity) {
            return Ok(await _mediator.Send(new UpdateActivity(activity)));
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(Guid Id) {
            return Ok(await _mediator.Send(new DeleteActivity(Id)));
        }
        #endregion
    }
}
