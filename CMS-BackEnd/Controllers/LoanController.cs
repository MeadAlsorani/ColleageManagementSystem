using CMS_BackEnd.Application.DTOs.Loan;
using CMS_BackEnd.Application.Features.Common;
using CMS_BackEnd.Application.Features.Loan.Requests.Commands;
using CMS_BackEnd.Application.Features.Loan.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CMS_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly IMediator mediator;

        public LoanController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        // GET: api/<LoanController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var records = await mediator.Send(new GetLoansListRequest());
            return Ok(records);
        }

        [HttpPost("GetWithPagination")]
        public async Task<ActionResult> GetWithPagination(ListPaginationRequest pagination)
        {
            return Ok(await mediator.Send(new GetLoansListRequest() { pagination = pagination }));
        }
        // GET api/<LoanController>/5
        [HttpGet("{staffId}")]
        public async Task<ActionResult> Get(int staffId)
        {
            return Ok(await mediator.Send(new GetStaffLoansRequest { StaffId = staffId }));
        }

        // POST api/<LoanController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateLoanDto data)
        {
            await mediator.Send(new CreateLoanRequest { Data = data });
            return Ok();
        }

        // PUT api/<LoanController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateLoanDto data)
        {
            await mediator.Send(new UpdateLoanRequest { Data = data });
            return Ok();
        }
    }
}
