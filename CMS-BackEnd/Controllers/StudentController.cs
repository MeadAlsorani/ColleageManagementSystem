using CMS_BackEnd.Application.DTOs.Student;
using CMS_BackEnd.Application.Features.Common;
using CMS_BackEnd.Application.Features.Student.Requests.Commands;
using CMS_BackEnd.Application.Features.Student.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CMS_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StudentController : ControllerBase
    {
        private readonly IMediator mediator;

        public StudentController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        // GET: api/<StudentController>
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var records = await mediator.Send(new StudentsListRequest());
            return Ok(records);
        }
        [HttpPost("GetWithPagination")]
        public async Task<ActionResult> GetWithPagination(ListPaginationRequest pagination)
        {
            var recods = await mediator.Send(new StudentsListRequest() { pagination = pagination });
            return Ok(recods);
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            return Ok(await mediator.Send(new StudentDetailsRequest() { Id = id }));
        }
        [HttpGet("WithCourses/{id}")]
        public async Task<ActionResult> GetWithCourses(int id)
        {
            return Ok(await mediator.Send(new GetStudentWithCoursesRequest() { Id = id }));
        }

        // POST api/<StudentController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateStudentDto student)
        {
            var stu = await mediator.Send(new CreateStudentCommand() { Student = student });
            return Ok(stu);
        }
        [HttpPost("CreateWithCourses")]
        public async Task<ActionResult> PostWithCourses([FromBody] CreateStudentDto student)
        {
            var stu = await mediator.Send(new CreateStudentWithCoursesRequest() { student = student });
            return Ok(stu);
        }
        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateStudentDto student)
        {
            await mediator.Send(new UpdateStudentRequest { Student = student });
            return Ok();
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await mediator.Send(new DeleteStudentRequest { Id = id });
            return Ok();
        }
    }
}
