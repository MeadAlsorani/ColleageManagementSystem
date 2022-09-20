using CMS_BackEnd.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Contracts.Identity
{
    public interface IAuthentication
    {
        Task<AuthResponse> Login(string username, string password);
    }
}
