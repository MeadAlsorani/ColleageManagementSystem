using CMS_BackEnd.Application.Features.Common;
using CMS_BackEnd.Application.Features.SalaryTemplate.Requests.Commands;
using CMS_BackEnd.Application.Features.SalaryTemplate.Requests.Queries;
using CMS_BackEnd.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CMS_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryTemplateController : ControllerBase
    {
        private readonly IMediator mediator;

        public SalaryTemplateController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        // GET: api/<SalaryTemplateController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await mediator.Send(new GetSalaryTemplatesListRequest()));
        }

        [HttpPost("GetWithPagination")]
        public async Task<ActionResult> GetWithPagination([FromBody] ListPaginationRequest request)
        {
            return Ok(await mediator.Send(new GetSalaryTemplatesListRequest() { pagination = request }));
        }
        // GET api/<SalaryTemplateController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            return Ok(await mediator.Send(new GetSalaryTemplateRequest() { Id = id }));
        }

        // POST api/<SalaryTemplateController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] SalaryTemplate value)
        {
            return Ok(await mediator.Send(new CreateSalaryTemplateRequest() { SalaryTemplate = value }));
        }

        // PUT api/<SalaryTemplateController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] SalaryTemplate value)
        {
            return Ok(await mediator.Send(new UpdateSalaryTemplateRequest() { SalaryTemplate = value }));
        }

        // DELETE api/<SalaryTemplateController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            return Ok(await mediator.Send(new DeleteSalaryTemplateRequest() { Id = id }));
        }
    }
}
