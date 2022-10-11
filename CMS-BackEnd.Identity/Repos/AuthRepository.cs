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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Identity.Repos
{
    public class AuthRepository : IAuthentication
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly CmsIdentityContext context;
        private readonly JwtSettings jwtSettings;

        public AuthRepository(SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager,
            IOptions<JwtSettings> jwtSettings,
            CmsIdentityContext context)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.context = context;
            this.jwtSettings = jwtSettings.Value;
        }

        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        public string GetPrincipalFromExpiredToken(string expiredToken)
        {
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key));
            var tokenValidationParameter = new TokenValidationParameters()
            {
                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = false,
                IssuerSigningKey = securityKey,
                ValidateLifetime = false
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(expiredToken, tokenValidationParameter, out securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            var tok = new JwtSecurityTokenHandler().ReadJwtToken(expiredToken);
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha512, StringComparison.InvariantCultureIgnoreCase))
                throw new SecurityTokenException("Invalid token");
            //if (string.IsNullOrEmpty(principal.Identity.Name) && tok.Payload.ContainsKey("name"))
            //    principal.Identity.Name = tok.Payload.FirstOrDefault(x => x.Key == "name").Value.ToString();
            return string.IsNullOrEmpty(principal.Identity.Name) ? tok.Payload.FirstOrDefault(x => x.Key == "name").Value.ToString() : principal.Identity.Name;
        }
        public async Task<AuthResponse> RefreshToken(string token, string refreshToken)
        {
            if (string.IsNullOrEmpty(token) || string.IsNullOrEmpty(refreshToken))
                throw new SecurityTokenException("Invalid token");

            var username = GetPrincipalFromExpiredToken(token);
            //var username = principle.Identity.Name;
            var user = context.Users.FirstOrDefault(x => x.UserName == username);
            if (user is null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime<= DateTime.Now)
                throw new SecurityTokenException("token expired");

            var newToken = await GenerateToken(user);
            //var newRefreshToken = GenerateRefreshToken();
            //user.RefreshToken = newRefreshToken;
            context.SaveChanges();
            return new AuthResponse
            {
                Email = username,
                Token = new JwtSecurityTokenHandler().WriteToken(newToken),
                UserName = username,
                Id = user.Id,
                FullName = $"{user.FirstName} {user.LastName}",
                Role = (await userManager.GetRolesAsync(user)).First(),
                RefreshToken = refreshToken
            };
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
            var refreshToken = GenerateRefreshToken();
            var dbUser = context.Users.Find(user.Id);

            dbUser!.RefreshToken = refreshToken;
            dbUser.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);
            await context.SaveChangesAsync();
            return new AuthResponse
            {
                Email = username,
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                UserName = username,
                Id = user.Id,
                FullName = $"{user.FirstName} {user.LastName}",
                Role = (await userManager.GetRolesAsync(user)).First(),
                RefreshToken = refreshToken
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
                new Claim(JwtRegisteredClaimNames.Name,user.UserName),
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
