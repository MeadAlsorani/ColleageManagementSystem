using CMS_BackEnd.Application.DTOs.Loan;
using CMS_BackEnd.Application.Features.Common;
using CMS_BackEnd.Application.Features.Loan.Requests.Commands;
using CMS_BackEnd.Application.Features.Loan.Requests.Queries;
using CMS_BackEnd.Domain;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CMS_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Accountant")]
    public class LoanController : ControllerBase
    {
        private readonly IMediator mediator;

        public LoanController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        // GET: api/<LoanController>
        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] int salaryTemplateId)
        {
            var records = await mediator.Send(new GetLoansListRequest() { Id = salaryTemplateId });
            return Ok(records);
        }
        // POST api/<LoanController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Loan data)
        {
            await mediator.Send(new CreateLoanRequest { Data = data });
            return Ok();
        }

        // PUT api/<LoanController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Loan data)
        {
            await mediator.Send(new UpdateLoanRequest { Data = data });
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await mediator.Send(new DeleteLoanRequest { Id = id });
            return Ok();
        }
    }
}
