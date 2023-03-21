using System.IdentityModel.Tokens.Jwt;
using System.Text;
using AplusServiceRRHH.Context;
using AplusServiceRRHH.CronJobs;
using AplusServiceRRHH.Middelware;
using AplusServiceRRHH.Modules;
using AplusServiceRRHH.Querys;
using AplusServiceRRHH.Repository;
using AplusServiceRRHH.Utils;
using comisionesapi.Utils;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

using Serilog;

var builder = WebApplication.CreateBuilder(args);

/*limpiar claim*/
JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
/* config serilog */
builder.Host.UseSerilog();
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Information)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .WriteTo.File("Logs/Log-.log", Serilog.Events.LogEventLevel.Warning, rollingInterval: RollingInterval.Day, outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u15}] {Message:lj}{NewLine}{Exception}")
    .CreateLogger();

/*
    *Services
*/
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(swgr =>
{
    swgr.SwaggerDoc("v1", new OpenApiInfo { Title = "Api Aplus Services" });
    swgr.AddSecurityDefinition("bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header
    });
    swgr.AddSecurityRequirement(new OpenApiSecurityRequirement{
        {
            new OpenApiSecurityScheme{
                Reference=new OpenApiReference{
                    Type= ReferenceType.SecurityScheme,
                    Id="bearer"
                }
            },
            new string[]{}
        }
    });
});

/*config Conexion*/
var getStringConnectionMysql = builder.Configuration.GetSection("connectionMysql").Get<StringConnection>();
var mysqlConnect = $"Server={getStringConnectionMysql.IpServer};Port={getStringConnectionMysql.Port};Database={getStringConnectionMysql.Database};User={getStringConnectionMysql.User};Password={getStringConnectionMysql.Password};";

var getStringConnectionSqlServer = builder.Configuration.GetSection("connectionSqlServer").Get<StringConnection>();
var sqlServerConnect = $"Server={getStringConnectionMysql.IpServer};Database={getStringConnectionMysql.Database};User={getStringConnectionMysql.User};Password={getStringConnectionMysql.Password};";

var getStringConnectionSqlServerDBComisiones = builder.Configuration.GetSection("connectionSqlServerDBComisiones").Get<StringConnection>();
var sqlServerConnectDBComisiones = $"Server={getStringConnectionSqlServerDBComisiones.IpServer};Database={getStringConnectionSqlServerDBComisiones.Database};User={getStringConnectionSqlServerDBComisiones.User};Password={getStringConnectionSqlServerDBComisiones.Password};TrustServerCertificate=True;";

builder.Services.AddDbContext<DbMysqlServerContext>(options =>
{
    options.UseMySql(mysqlConnect, ServerVersion.AutoDetect(mysqlConnect));
});
builder.Services.AddDbContext<DbSqlServerContext>(options =>
{
    options.UseSqlServer(sqlServerConnect);
});
builder.Services.AddDbContext<DbContextComisiones>(options =>
{
    options.UseSqlServer(sqlServerConnectDBComisiones);
});
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
/*
    *utilidades
*/
builder.Services.AddTransient<RazorRendererHelper>();
builder.Services.AddTransient<GenerateDocumento>();
builder.Services.AddTransient<GeneratePlantilla>();
builder.Services.AddTransient<ResolverUser>();
/*
    *Module
*/
builder.Services.AddTransient<AuthenticationModule>();
builder.Services.AddTransient<TipoDocumentoModule>();
builder.Services.AddTransient<DepartamentoModule>();
builder.Services.AddTransient<UnidadModule>();
builder.Services.AddTransient<TipoCuentaModule>();
builder.Services.AddTransient<TipoContratoModule>();
builder.Services.AddTransient<SucursalModule>();
builder.Services.AddTransient<SexoModule>();
builder.Services.AddTransient<PaisModule>();
builder.Services.AddTransient<OficinaModule>();
builder.Services.AddTransient<ModContratoModule>();
builder.Services.AddTransient<InformacionContableModule>();
builder.Services.AddTransient<FormaPagoModule>();
builder.Services.AddTransient<FormacionPrincipalModule>();
builder.Services.AddTransient<EstadoCivilModule>();
builder.Services.AddTransient<ClasificacionLaboralModule>();
builder.Services.AddTransient<CentroCostoModule>();
builder.Services.AddTransient<CajaSaludModule>();
builder.Services.AddTransient<BancoModule>();
builder.Services.AddTransient<CargoModule>();
builder.Services.AddTransient<AdministracionPensionesModule>();
builder.Services.AddTransient<ColaboradorModule>();
builder.Services.AddTransient<ContratoModule>();
builder.Services.AddTransient<AsistenciaModule>();

/*
    *Repository
*/
builder.Services.AddTransient<AuthenticationRepository>();
builder.Services.AddTransient<TipoDocumentoRepository>();
builder.Services.AddTransient<DepartamentoRepositorio>();
builder.Services.AddTransient<UnidadRepository>();
builder.Services.AddTransient<TipoCuentaRepository>();
builder.Services.AddTransient<TipoContratoRepository>();
builder.Services.AddTransient<SucursalRepository>();
builder.Services.AddTransient<SexoRepository>();
builder.Services.AddTransient<PaisRepository>();
builder.Services.AddTransient<OficinaRepository>();
builder.Services.AddTransient<ModoContratoRepository>();
builder.Services.AddTransient<InformacionContableRepository>();
builder.Services.AddTransient<FormaPagoRepository>();
builder.Services.AddTransient<FormacionPrincipalRepository>();
builder.Services.AddTransient<EstadoCivilRepository>();
builder.Services.AddTransient<ClasificacionLaboralRepository>();
builder.Services.AddTransient<CentroCostoRepository>();
builder.Services.AddTransient<CajaSaludRepository>();
builder.Services.AddTransient<BancoRepository>();
builder.Services.AddTransient<CargoRepository>();
builder.Services.AddTransient<AdministracionPesionRepository>();
builder.Services.AddTransient<ColaboradorRepository>();
builder.Services.AddTransient<EmpresaRepository>();
builder.Services.AddTransient<AsistenciaRepository>();
builder.Services.AddTransient<UsuarioRepository>();

/*
    *Querys
*/
builder.Services.AddTransient<AuthenticationQuery>();

builder.Services.AddTransient<UnidadQuery>();
builder.Services.AddTransient<TipoDocumentoQuery>();
builder.Services.AddTransient<TipoCuentaQuery>();
builder.Services.AddTransient<TipoContratoQuery>();
builder.Services.AddTransient<SucursalQuery>();
builder.Services.AddTransient<SexoQuery>();
builder.Services.AddTransient<PaisQuery>();
builder.Services.AddTransient<OficinaQuery>();
builder.Services.AddTransient<ModContratoQuery>();
builder.Services.AddTransient<InformacionContableQuery>();
builder.Services.AddTransient<FormaPagoQuery>();
builder.Services.AddTransient<FormacionPrincipalQuery>();
builder.Services.AddTransient<EstadoCivilQuery>();
builder.Services.AddTransient<DepartamentoQuery>();
builder.Services.AddTransient<ClasificacionLaboralQuery>();
builder.Services.AddTransient<CentroCostoQuery>();
builder.Services.AddTransient<CajaSaludQuery>();
builder.Services.AddTransient<BancosQuery>();
builder.Services.AddTransient<CargoQuery>();
builder.Services.AddTransient<AdministracionPesionQuery>();
builder.Services.AddTransient<ColaboradorQuery>();
builder.Services.AddTransient<EmpresaQuery>();
builder.Services.AddTransient<AsistenciaQuery>();
builder.Services.AddTransient<RolQuery>();
builder.Services.AddTransient<UsuarioQuery>();
builder.Services.AddTransient<UsuarioRolQuery>();

/*service Worker*/
builder.Services.AddHostedService<ServiceJob>();

builder.Services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));
/*
    *others
*/
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
.AddJwtBearer(options => options.TokenValidationParameters = new TokenValidationParameters
{
    ValidateIssuer = false,
    ValidateAudience = false,
    ValidateLifetime = true,
    ValidateIssuerSigningKey = true,
    IssuerSigningKey = new SymmetricSecurityKey(
        Encoding.UTF8.GetBytes(builder.Configuration.GetSection("KeyTokken").Value)
    ),
    ClockSkew = TimeSpan.Zero
});

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
.AddEntityFrameworkStores<DbContextComisiones>()
.AddDefaultTokenProviders();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(
    options =>
    {
        options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().WithExposedHeaders("Authorization");
    }
);
app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();


try
{
    Log.Warning("Iniciando Web API");
    app.UseRefreshToken();
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated unexpectedly");
    return;
}
