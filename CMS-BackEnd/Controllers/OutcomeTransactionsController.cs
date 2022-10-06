using CMS_BackEnd.Application.DTOs.OutcomeTransaction;
using CMS_BackEnd.Application.Features.Common;
using CMS_BackEnd.Application.Features.OutcomeTransaction.Requests.Commands;
using CMS_BackEnd.Application.Features.OutcomeTransaction.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CMS_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Accountant")]
    public class OutcomeTransactionsController : ControllerBase
    {
        private readonly IMediator mediator;

        public OutcomeTransactionsController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        // GET: api/<OutcomeTransactionsController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var records = await mediator.Send(new GetOutcomesListRequest());
            return Ok(records);
        }
        [HttpPost("GetWithPagination")]
        public async Task<ActionResult> GetWithPagination([FromBody] ListPaginationRequest listPagination)
        {
            return Ok(await mediator.Send(new GetOutcomesListRequest { pagination = listPagination }));
        }
        // GET api/<OutcomeTransactionsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var record = await mediator.Send(new GetOutcomeDetailsRequest { Id = id });
            return Ok(record);
        }

        // POST api/<OutcomeTransactionsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateOutcomeTransactionDto data)
        {
            await mediator.Send(new CreateOutcomeTransactionRequest { Data = data });
            return Ok();
        }

        // PUT api/<OutcomeTransactionsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateOutcomeTransactionDto data)
        {
            await mediator.Send(new UpdateOutcomeTransactionRequest { Data = data });
            return Ok();
        }

        // DELETE api/<OutcomeTransactionsController>/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult> Delete(int id)
        //{
        //    return Ok();
        //}
    }
}
