using CMS_BackEnd.Application.Models;
using System.Security.Claims;

namespace CMS_BackEnd.Application.Contracts.Identity
{
    public interface IAuthentication
    {
        Task<AuthResponse> Login(string username, string password);
        string GenerateRefreshToken();
        string GetPrincipalFromExpiredToken(string expiredToken);
        Task<AuthResponse> RefreshToken(string token, string refreshToken);

    }
}
