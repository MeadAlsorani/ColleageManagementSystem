using CMS_BackEnd.Application.Constants;
using CMS_BackEnd.Application.Contracts.Identity;
using CMS_BackEnd.Application.Models;
using CMS_BackEnd.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Identity.Repos
{
    public class AuthRepository : IAuthentication
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly JwtSettings jwtSettings;

        public AuthRepository(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, IOptions<JwtSettings> jwtSettings)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.jwtSettings = jwtSettings.Value;
        }
        public async Task<AuthResponse> Login(string username, string password)
        {
            var user = await userManager.FindByEmailAsync(username);
            if (user == null)
            {
                throw new AccessViolationException($"User with username: {username} doesn't exist");
            }

            var result = await signInManager.PasswordSignInAsync(user, password, false, false);
            if (!result.Succeeded)
            {
                throw new AccessViolationException($"Entered credentials are not valid");
            }
            JwtSecurityToken token = await GenerateToken(user);
            return new AuthResponse
            {
                Email = username,
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                UserName = username,
                Id = user.Id
            };
        }

        private async Task<JwtSecurityToken> GenerateToken(ApplicationUser user)
        {
            var userClaims = await userManager.GetClaimsAsync(user);
            var roles = await userManager.GetRolesAsync(user);

            var roleClaims = new List<Claim>();
            foreach (var role in roles)
            {
                roleClaims.Add(new Claim(ClaimTypes.Role, role));
            }

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub,user.UserName),
                new Claim(JwtRegisteredClaimNames.Email,user.Email),
                new Claim(CustomClaimTypes.Uid,user.Id)
            }.Union(userClaims).Union(roleClaims);

            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key));

            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512);
            var token = new JwtSecurityToken(
                issuer: jwtSettings.Issuer,
                audience: jwtSettings.Audience,
                claims,
                expires: DateTime.UtcNow.AddMinutes(jwtSettings.Duration),
                signingCredentials: credentials
            );
            return token;
        }
    }
}
