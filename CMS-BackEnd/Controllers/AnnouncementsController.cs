using CMS_BackEnd.Application.DTOs.Announcement;
using CMS_BackEnd.Application.Features.Announcement.Requests.Commands;
using CMS_BackEnd.Application.Features.Announcement.Requests.Queries;
using CMS_BackEnd.Application.Features.Common;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CMS_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AnnouncementsController : ControllerBase
    {
        private readonly IMediator mediator;

        // GET: api/<AnnouncementsController>
        public AnnouncementsController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var records = await mediator.Send(new AnnouncementListRequest());
            return Ok(records);
        }

        [HttpPost("GetWithPagination")]
        public async Task<ActionResult> GetWithPagination(ListPaginationRequest listPagination)
        {
            var records = await mediator.Send(new AnnouncementListRequest() { request=listPagination});
            return Ok(records);
        }
        // GET api/<AnnouncementsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var record = await mediator.Send(new AnnouncementDetailsRequest() { Id = id });
            return Ok(record);
        }

        // POST api/<AnnouncementsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AnnouncementRecordDto announcement)
        {
            var record = await mediator.Send(new CreateAnnouncementRequest() { announcement = announcement });
            return Ok(record);
        }

        // PUT api/<AnnouncementsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] AnnouncementRecordDto announcement)
        {
            await mediator.Send(new UpdateAnnouncementRequest() { record = announcement });
            return Ok();
        }

        // DELETE api/<AnnouncementsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await mediator.Send(new DeleteAnnouncementRequest() { Id = id });
            return Ok();
        }
    }
}
