using CMS_BackEnd.Application.Features.Announcement.Requests.Queries;
using CMS_BackEnd.Application.Features.Dashboard.Requests;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMS_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IMediator mediator;

        public DashboardController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet("Announcements")]
        public async Task<ActionResult> GetAnnouncmenets(int month)
        {
            var records = await mediator.Send(new GetAnnouncementsByMonthRequest() { Month = month });
            return Ok(records);
        }

        [HttpGet("Counts")]
        public async Task<ActionResult> Counts()
        {
            return Ok(await mediator.Send(new CountsRequest()));
        }

        [HttpGet("Incomes")]
        public async Task<ActionResult> GetIncomes(int month = -1)
        {
            return Ok(await mediator.Send(new GetIncomeSumRequest() { Month = month }));
        }

        [HttpGet("Outcome")]
        public async Task<ActionResult> GetOutcomes(int month = -1)
        {
            return Ok(await mediator.Send(new GetOutcomesRequest() { Month = month }));
        }

        [HttpGet("AttendanceToday")]
        public async Task<ActionResult> GetStudentsToday()
        {
            return Ok(await mediator.Send(new GetAttendanceCountsRequest()));
        }
    }
}
