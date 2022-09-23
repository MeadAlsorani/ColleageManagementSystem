using CMS_BackEnd.Application.DTOs.Course;
using CMS_BackEnd.Application.Features.Common;
using CMS_BackEnd.Application.Features.Course.Requests.Commands;
using CMS_BackEnd.Application.Features.Course.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace CMS_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CourseController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IHttpContextAccessor httpContext;

        public CourseController(IMediator mediator, IHttpContextAccessor httpContext)
        {
            this.mediator = mediator;
            this.httpContext = httpContext;
        }
        // GET: api/<CourseController>
        [HttpGet]
        public async Task<ActionResult<List<CourseListDto>>> Get()
        {
            var records = await mediator.Send(new CoursesListRequest());
            return Ok(records);
        }


        [HttpPost("GetWithPagination")]
        public async Task<ActionResult<List<CourseListDto>>> GetWithPagination(ListPaginationRequest request)
        {
            var records = await mediator.Send(new CoursesListRequest { pagination = request });
            return Ok(records);
        }
        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CourseDetailsDto>> Get(int id)
        {
            var record = await mediator.Send(new CourseDetailsRequest { Id = id });
            return Ok(record);
        }

        // POST api/<CourseController>
        [HttpPost]
        public async Task Post([FromBody] CreateCourseDto course)
        {
            await mediator.Send(new CreateCourseRequest { Course = course });

        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] CreateCourseDto course)
        {
            if (id != course.Id)
            {
                return BadRequest();
            }
            await mediator.Send(new UpdateCourseRequest { Course = course });
            return Ok();
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await mediator.Send(new DeleteCourseRequest { Id = id });
            return Ok();
        }
    }
}
