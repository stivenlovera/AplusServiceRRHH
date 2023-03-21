using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace AplusServiceRRHH.Middelware
{
    public static class RefreshTokenMiddelwareExtenciones
    {
        public static IApplicationBuilder UseRefreshToken(this IApplicationBuilder app)
        {
            return app.UseMiddleware<RefreshTokenMiddelware>();
        }
    }
    public class RefreshTokenMiddelware
    {
        private readonly RequestDelegate _requestDelegate;
        private readonly ILogger<RefreshTokenMiddelware> _logger;
        private readonly IConfiguration _configuration;

        public RefreshTokenMiddelware(
            RequestDelegate requestDelegate,
            ILogger<RefreshTokenMiddelware> logger,
            IConfiguration configuration
            )
        {
            this._requestDelegate = requestDelegate;
            this._logger = logger;
            this._configuration = configuration;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                var aux = httpContext.User.Claims;
                var id = httpContext.User.Claims.Where(user => user.Type == "id").FirstOrDefault();
                var colaboradorId = httpContext.User.Claims.Where(user => user.Type == ClaimTypes.Role).FirstOrDefault();

                var roles = httpContext.User.FindAll(ClaimTypes.Role).ToList();
                //this._logger.LogWarning($"ROLES => {JsonConvert.SerializeObject(roles, Formatting.Indented)}");
                var claims = new List<Claim>(){
                    new Claim("id", id.Value),
                    new Claim("colaboradorId", colaboradorId.Value),
                    new Claim(ClaimTypes.Role , "role")
                };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this._configuration.GetSection("KeyTokken").Value));
                var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var expiration = DateTime.UtcNow.AddMinutes(30);
                var securityToken = new JwtSecurityToken(
                    issuer: null,
                    audience: null,
                    claims: claims,
                    expires: expiration,
                    signingCredentials: cred
                );
                var token = new JwtSecurityTokenHandler().WriteToken(securityToken);
                string tokenAnterior = httpContext.Request.Headers.Authorization;
                string tokenAnteriorClean = tokenAnterior.Replace("Bearer ", "");

                httpContext.Response.Headers.Add("Authorization", token);
            }
            catch (System.Exception e)
            {
                this._logger.LogWarning($"LLEGO AL CATCH {e}");
                //httpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
            }
            await this._requestDelegate(httpContext);
        }
    }
}