using CMS_BackEnd.Application.DTOs.SessionYear;
using CMS_BackEnd.Application.Features.Common;
using CMS_BackEnd.Application.Features.SessionYear.Requests.Commands;
using CMS_BackEnd.Application.Features.SessionYear.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CMS_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionYearController : ControllerBase
    {
        private readonly IMediator mediator;

        public SessionYearController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        // GET: api/<SessionYearController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await mediator.Send(new GetSessionYearsListRequest()));
        }
        [HttpPost("GetWithPagination")]
        public async Task<ActionResult> GetWithPaginationAsync(ListPaginationRequest request)
        {
            return Ok(await mediator.Send(new GetSessionYearsListRequest() { request = request }));
        }

        // GET api/<SessionYearController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var records = await mediator.Send(new GetSessionYearsListRequest());
            return Ok(records.Records.FirstOrDefault(x => x.Id == id));
        }

        // POST api/<SessionYearController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateSessionYearDto data)
        {
            return Ok(await mediator.Send(new CreateSessionYearRequest() { data = data }));
        }

        // PUT api/<SessionYearController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateSessionYearDto data)
        {
            await mediator.Send(new UpdateSessionYearRequest() { data = data });
            return Ok();
        }

        // DELETE api/<SessionYearController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await mediator.Send(new DeleteSessionYearRequest() { Id = id });
            return Ok();
        }
    }
}
