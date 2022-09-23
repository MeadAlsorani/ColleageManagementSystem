using CMS_BackEnd.Application.Contracts.Identity;
using CMS_BackEnd.Application.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMS_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthentication authentication;

        public AuthenticationController(IAuthentication authentication)
        {
            this.authentication = authentication;
        }
        [HttpGet]
        public async Task<ActionResult<AuthResponse>> Login(string username, string password)
        {
            var result = await authentication.Login(username, password);
            return Ok(result);
        }
    }
}
