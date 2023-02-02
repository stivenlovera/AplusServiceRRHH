using AplusServiceRRHH.Context;
using AplusServiceRRHH.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AplusServiceRRHH.Controllers;

[ApiController]
[Route("api")]
[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IConfiguration configuration;
    private readonly UserManager<IdentityUser> _userManager;

    public DbMysqlServerContext DbMysqlServerContext { get; }

    public WeatherForecastController(
        ILogger<WeatherForecastController> logger,
        IConfiguration configuration,
        DbMysqlServerContext DbMysqlServerContext,
        UserManager<IdentityUser> userManager
        )
    {
        _logger = logger;
        this.configuration = configuration;
        this.DbMysqlServerContext = DbMysqlServerContext;
        this._userManager = userManager;
    }
    [AllowAnonymous]
    [HttpGet("/demo")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    [HttpGet("otros")]
    public string Demo()
    {
        return this.configuration.GetValue<string>("connectionMysql:IpServer");
    }
    [HttpGet("select")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public async Task<List<string>> DemoSelect()
    {
        var aux = HttpContext.User.Claims;
        var claimUser = HttpContext.User.Claims.Where(user => user.Type == "ci").FirstOrDefault();
        var ci = claimUser.Value;
        var usuario = await this._userManager.FindByIdAsync(ci);
        //var Usuario = usuario.Id;
        var verificar=await this._userManager.VerifyUserTokenAsync(usuario, "api-comisiones", "cliente","eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJjaSI6IjAwMTQzMjYiLCJyb2wiOiJjbGllbnRlIiwiZXhwIjoxNjczMTIwNjA2fQ.8kkpgOZtdO4JrMSCPrTCfhB-TF_P7M0b0mOC3DXDZnw");
        this._logger.LogWarning("entrado a api");
       /*  var resultado = await this.DbMysqlServerContext.AdministracionRed.FromSqlRaw(@"
            SELECT AR.susuarioadd,AR.dtfechamod,AR.lcontacto_id
                FROM AdministracionRed as AR
            WHERE
                AR.lpatrocinador2g = '608'
                AND AR.lpatrocinador1g = '85062';
            ").ToListAsync(); */
        return new List<string>();
    }
}

