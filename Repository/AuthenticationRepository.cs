using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Context;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Entities.DBComisiones;
using AplusServiceRRHH.Querys;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace AplusServiceRRHH.Repository
{
    public class AuthenticationRepository
    {
        private readonly ILogger<AuthenticationRepository> _logger;
        private readonly IConfiguration configuration;
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly DbContextComisiones _dbContextComisiones;
        private readonly AuthenticationQuery _authenticationQuery;

        public AuthenticationRepository(
            ILogger<AuthenticationRepository> logger,
            IConfiguration configuration,
            DbMysqlServerContext DbMysqlServerContext,
            DbContextComisiones dbContextComisiones,
            AuthenticationQuery authenticationQuery
        )
        {
            this._logger = logger;
            this.configuration = configuration;
            this._dbMysqlServerContext = DbMysqlServerContext;
            this._dbContextComisiones = dbContextComisiones;
            this._authenticationQuery = authenticationQuery;
        }
        public async Task<UsuarioEmpresa> LoginUserRepository(string Usuario, string Password)
        {
            this._logger.LogWarning($"AuthenticationRepository/LoginGralUsuario({Usuario},{Password}): Inizialize...");
            var data = await this._dbMysqlServerContext.Usuario.FromSqlRaw(this._authenticationQuery.LoginQuery(Usuario, Password))
            .Join(
                this._dbMysqlServerContext.Empresa,
                u => u.EmpresaId,
                e => e.Id,
                (u, e) => new UsuarioEmpresa
                {
                    NombreCompleto = u.nombreCompleto,
                    Nombre = e.Nombre
                }
            ).ToListAsync();

            var resultado = data.FirstOrDefault();
            if (resultado != null)
            {
                this._logger.LogWarning($"AuthenticationRepository/LoginGralUsuario SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"AuthenticationRepository/LoginGralUsuario: Message => 'No existe Usuario Registrado' CONSULT => {this._authenticationQuery.LoginQuery(Usuario, Password)}");
                throw new Exception("No existe Usuario Registrado");
            }
        }
    }
    public class UsuarioEmpresa
    {
        public string NombreCompleto { get; set; }
        public string Nombre { get; set; }
    }
}