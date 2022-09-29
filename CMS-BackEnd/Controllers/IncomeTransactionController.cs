using CMS_BackEnd.Application.DTOs.IncomingTransaction;
using CMS_BackEnd.Application.Features.Common;
using CMS_BackEnd.Application.Features.IncomeTransaction.Requests.Commands;
using CMS_BackEnd.Application.Features.IncomeTransaction.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CMS_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncomeTransactionController : ControllerBase
    {
        private readonly IMediator mediator;

        public IncomeTransactionController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        // GET: api/<IncomeTransactionController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var records = await mediator.Send(new IncomingTransactionsListRequest());
            return Ok(records);
        }
        [HttpPost("GetWithPagination")]
        public async Task<ActionResult> GetWithPagination(ListPaginationRequest listPagination)
        {
            var records = await mediator.Send(new IncomingTransactionsListRequest() { Pagination = listPagination });
            return Ok(records);
        }
        // GET api/<IncomeTransactionController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var record = await mediator.Send(new IncomingTransactionDetailsRequest() { Id = id });
            return Ok(record);
        }

        [HttpGet("GetStudentIncomingTransactions")]
        public async Task<ActionResult> GetStudentIncomingTransactions(int studentId, DateTime? start, DateTime? end)
        {
            var records = await mediator.Send(new GetStudentIncomingTransactionRequest()
            {
                StudentId = studentId,
                Start = start,
                End = end
            });
            return Ok(records);
        }
        // POST api/<IncomeTransactionController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateIncomingTransactionDto data)
        {
            await mediator.Send(new CreateIncomingTransactionRequest { Data = data });
            return Ok();
        }

        // PUT api/<IncomeTransactionController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateIncomingTransactionDto data)
        {
            await mediator.Send(new UpdateIncomingTransactionRequest { Data = data });
            return Ok();
        }
    }
}
