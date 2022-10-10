using CMS_BackEnd.Application.DTOs.Staff;
using CMS_BackEnd.Application.Features.Common;
using CMS_BackEnd.Application.Features.Staff.Requests.Commands;
using CMS_BackEnd.Application.Features.Staff.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CMS_BackEnd.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StaffController : ControllerBase
    {
        private readonly IMediator mediator;

        public StaffController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        // GET: api/<StaffController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var records = await mediator.Send(new GetStaffsListRequest());
            return Ok(records);
        }

        [HttpPost("GetWithPagination")]
        public async Task<ActionResult> GetWithPagination([FromBody] ListPaginationRequest pagination)
        {
            var records = await mediator.Send(new GetStaffsListRequest() { pagination = pagination });
            return Ok(records);
        }
        // GET api/<StaffController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            return Ok(await mediator.Send(new GetStaffDetailsRequest() { Id = id }));
        }

        // POST api/<StaffController>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Post([FromBody] CreateStaffDto staff)
        {
            var record = await mediator.Send(new CreateStaffRequest() { Staff = staff });
            return Ok(record);
        }

        // PUT api/<StaffController>/5
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateStaffDto update)
        {
            await mediator.Send(new UpdateStaffRequest() { Staff = update });
            return Ok();
        }

        // DELETE api/<StaffController>/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Delete(int id)
        {
            await mediator.Send(new DeleteStaffRequest() { Id = id });
            return Ok();
        }
    }
}
