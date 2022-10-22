using CMS_BackEnd.Application.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMS_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class CommonController : ControllerBase
    {
        public CommonController()
        {

        }

        [HttpGet]
        public ActionResult GetMenus()
        {
            return Ok(new Menus().menus);
        }
    }
}
