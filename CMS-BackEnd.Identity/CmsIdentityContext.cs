using CMS_BackEnd.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CMS_BackEnd.Identity
{
    public class CmsIdentityContext:IdentityDbContext<ApplicationUser>
    {

    }
}