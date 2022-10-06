using CMS_BackEnd.Application.DTOs.Attendance;
using CMS_BackEnd.Application.Features.Attendance.Requests.Commands;
using CMS_BackEnd.Application.Features.Attendance.Requests.Queries;
using CMS_BackEnd.Application.Features.Common;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CMS_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Reciptionist")]
    public class AttendanceController : ControllerBase
    {
        private readonly IMediator mediator;

        public AttendanceController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        // GET: api/<AttendanceController>
        [HttpGet]
        [Authorize(Roles = "Reciptionist,Admin,Manager")]
        public async Task<ActionResult<IReadOnlyList<AttendancesListDto>>> Get()
        {
            var records = await mediator.Send(new GetAttendancesRequest());
            return Ok(records);
        }

        [HttpPost("GetWithPagination")]
        [Authorize(Roles = "Reciptionist,Admin,Manager")]
        public async Task<ActionResult<IReadOnlyList<AttendancesListDto>>> Get(ListPaginationRequest request)
        {
            var records = await mediator.Send(new GetAttendancesRequest() { pagination = request });
            return Ok(records);
        }

        // GET api/<AttendanceController>/5
        [HttpGet("Student/{id}")]
        [Authorize(Roles = "Reciptionist,Admin,Manager")]
        public async Task<ActionResult<IReadOnlyList<StudentAttendanceDto>>> GetStudentAttendances(int id, DateTime startDate, DateTime endDate)
        {
            var record = await mediator.Send(new GetStudentAttendancesListRequest()
            {
                StudentId = id,
                EndDate = endDate,
                StartDate = startDate
            });
            return Ok(record);
        }
        [HttpGet("Staff/{id}")]
        public async Task<ActionResult<IReadOnlyList<StudentAttendanceDto>>> GetStaffAttendances(int id, DateTime startDate, DateTime endDate)
        {
            var record = await mediator.Send(new GetStaffAtendancesListRequest()
            {
                StaffId = id,
                EndDate = endDate,
                StartDate = startDate
            });
            return Ok(record);
        }
        // POST api/<AttendanceController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateAttendanceDto data)
        {
            await mediator.Send(new CreateAttendanceRequest() { CreateData = data });
            return Ok();
        }

        // DELETE api/<AttendanceController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await mediator.Send(new DeleteAttendanceRequest() { Id = id });
            return Ok();
        }
    }
}
