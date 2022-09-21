using CMS_BackEnd.Application.Models;

namespace CMS_BackEnd.Application.Contracts.Identity
{
    public interface IAuthentication
    {
        Task<AuthResponse> Login(string username, string password);

    }
}
