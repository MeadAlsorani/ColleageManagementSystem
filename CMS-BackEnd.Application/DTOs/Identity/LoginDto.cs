using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.Identity
{
    public class LoginDto
    {
        public string? username { get; set; }
        public string? password { get; set; }
    }
}
