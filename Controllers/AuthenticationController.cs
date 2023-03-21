using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AplusServiceRRHH.Dtos;
using AplusServiceRRHH.Dtos.Auth;
using AplusServiceRRHH.Modules;
using comisionesapi.Utils;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
namespace AplusServiceRRHH.Controllers
{
    [ApiController]
    [Route("api/auth")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class AuthenticationController : ControllerBase
    {
        private readonly ILogger<AuthenticationController> _logger;
        private readonly AuthenticationModule _authenticacionModule;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ResolverUser _resolverUser;
        private readonly ColaboradorModule _colaboradorModule;

        public AuthenticationController(
            ILogger<AuthenticationController> logger,
            AuthenticationModule authenticacionModule,
            UserManager<IdentityUser> userManager,
            IConfiguration configuration,
            SignInManager<IdentityUser> signInManager,
            ResolverUser resolverUser,
            ColaboradorModule colaboradorModule
        )
        {
            this._logger = logger;
            this._authenticacionModule = authenticacionModule;
            this._userManager = userManager;
            this._configuration = configuration;
            this._signInManager = signInManager;
            this._resolverUser = resolverUser;
            this._colaboradorModule = colaboradorModule;
        }
        [HttpPost("login")] // api/Auth/login
        [AllowAnonymous]
        public async Task<Response> Login(LoginDto loginDto)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} Login({loginDto.Usuario},{loginDto.Password}) Inizialize ...");
            try
            {
                //logica
                var user = await this._authenticacionModule.Login(loginDto.Usuario, loginDto.Password);
                //delete registro e logeo
                var generateToken = this.CreateAuthorize(user.usuario, user.id, user.HHRRcolaboradorId, $"{user.Nombre1} {user.Nombre2} {user.Nombre3} {user.ApellidoPaterno} {user.ApellidoMaterno} {user.ApellidoCasado}");
                this._logger.LogWarning($"Login() SUCCESS => {JsonConvert.SerializeObject(generateToken, Formatting.Indented)}");
                var result = new Response
                {
                    Status = 1,
                    Message = "Bienvenido",
                    data = generateToken
                };
                return result;
            }
            catch (System.Exception e)
            {
                var result = new Response
                {
                    Status = 0,
                    Message = e.Message,
                    data = null
                };
                this._logger.LogError($"Login() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpGet] // api/Auth/login
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public /* async Task< */Response/* > */ Authenticacion()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} Authenticacion() Inizialize ...");
            try
            {
                //logica
                var user=this._resolverUser.GetUser(HttpContext);
                //var verificar = await this._colaboradorModule.ObtenerColaboradorId(user.colaboradorId);
                var result = new Response
                {
                    Status = 1,
                    Message = "Autorizado",
                    data = new
                    {
                        nombreCompleto = "",//$"{verificar.Nombre1} {verificar.Nombre2} {verificar.Nombre3} {verificar.ApellidoPaterno} {verificar.ApellidoMaterno} {verificar.ApellidoCasado}",
                        empresa = "Aplus Security"
                    }
                };
                return result;
            }
            catch (System.Exception e)
            {
                var result = new Response
                {
                    Status = 0,
                    Message = e.Message,
                    data = null
                };
                this._logger.LogError($"Login() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }

        }
        [HttpPost("registrar")] // api/Auth/login
        public async Task<Response> Register(LoginDto loginDto)
        {
            var Usuario = new IdentityUser
            {
                UserName = loginDto.Usuario
            };
            var result = await this._userManager.CreateAsync(
                Usuario, loginDto.Password
            );

            if (result.Succeeded)
            {
                var success = new Response
                {
                    Status = 0,
                    Message = "Error",
                    data = this.ConstrucToken(1, 1)
                };
                return success;
            }
            else
            {
                var error = new Response
                {
                    Status = 0,
                    Message = "Error",
                    data = null
                };
                return error;
            }
        }
        //Function Constructor Token 
        private TokenDto CreateAuthorize(string usuario, int id, int colaboradorId, string nombrecompleto)
        {
            var user = new IdentityUser
            {
                Id = id.ToString(),
                UserName = usuario
            };

            var generateToken = this.ConstrucToken(id, colaboradorId);
            this._logger.LogWarning($"CreateAuthorize() SUCCESS => Token generado correctamente");
            return generateToken;
        }
        //Function Construct token
        private TokenDto ConstrucToken(int id, int colaboradorId)
        {
            var claims = new List<Claim>(){
                new Claim("id", id.ToString()),
                new Claim("colaboradorId",colaboradorId.ToString()),
                new Claim(ClaimTypes.Role,"administrador"),//roles
                new Claim(ClaimTypes.Role,"invitado")//roles
            };
            this._logger.LogWarning($"Create Claims() SUCCESS => {JsonConvert.SerializeObject(claims, Formatting.Indented)}");
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this._configuration.GetSection("KeyTokken").Value));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiration = DateTime.UtcNow.AddHours(1);
            var securityToken = new JwtSecurityToken(
                issuer: null,
                audience: null,
                claims: claims,
                expires: expiration,
                signingCredentials: cred
            );

            return new TokenDto()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(securityToken),
                Expiration = expiration
            };
        }

        [HttpGet("refresh-token")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        private TokenDto RefreshToken(LoginDto loginDto)
        {
            var aux = HttpContext.User.Claims;
            var claimsCi = HttpContext.User.Claims.Where(user => user.Type == "Ci").FirstOrDefault();
            var claimsRol = HttpContext.User.Claims.Where(user => user.Type == "rol").FirstOrDefault();
            var ci = claimsCi.Value;
            var rol = claimsRol.Value;
            var login = new LoginDto()
            {
                Usuario = ci,
                Password = "Demo1?"
            };
            return this.ConstrucToken(1, 1);
        }

        [HttpGet("logout")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        private TokenDto Logout()
        {
            var aux = HttpContext.User.Claims;
            var claimsCi = HttpContext.User.Claims.Where(user => user.Type == "Ci").FirstOrDefault();
            var claimsRol = HttpContext.User.Claims.Where(user => user.Type == "rol").FirstOrDefault();
            var ci = claimsCi.Value;
            var rol = claimsRol.Value;
            var login = new LoginDto()
            {
                Usuario = ci,
                Password = "sdfSFSDA123?¡"
            };
            return this.ConstrucToken(1, 1);
        }
        private async Task<bool> ResetUser(LoginDto loginDto)
        {
            var validate = await this._userManager.FindByIdAsync(loginDto.Usuario);
            if (validate != null)
            {
                var usuario = await this._userManager.DeleteAsync(validate);
                if (usuario.Succeeded)
                {
                    this._logger.LogWarning($"Delete Login() => {usuario.Succeeded}");
                }
            }
            return true;
        }
    }
}