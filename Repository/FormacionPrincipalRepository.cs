using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Context;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Querys;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace AplusServiceRRHH.Repository
{
    public class FormacionPrincipalRepository
    {
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly ILogger<FormacionPrincipalRepository> _logger;
        private readonly FormacionPrincipalQuery _formacionPrincipalQuery;

        public FormacionPrincipalRepository(
            DbMysqlServerContext DbMysqlServerContext,
            ILogger<FormacionPrincipalRepository> logger,
            FormacionPrincipalQuery formacionPrincipalQuery
        )
        {
            this._dbMysqlServerContext = DbMysqlServerContext;
            this._logger = logger;
            this._formacionPrincipalQuery = formacionPrincipalQuery;
        }
        public async Task<List<HHRRFormacionPrincipal>> ObtenerFormacionPrincipal()
        {
            this._logger.LogWarning($"FormacionPrincipalRepository/ObtenerFormacionPrincipals(): Inizialize...");
            var sql = this._formacionPrincipalQuery.ObtenerFormacionPrincipal();
            var resultado = await this._dbMysqlServerContext.HHRRFormacionPrincipal.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"FormacionPrincipalRepository/ObtenerFormacionPrincipals SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"FormacionPrincipalRepository/ObtenerFormacionPrincipals: Message => 'Error al buscar FormacionPrincipals' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRFormacionPrincipal>> ObtenerFormacionPrincipalId(int id)
        {
            this._logger.LogWarning($"FormacionPrincipalRepository/ObtenerFormacionPrincipalId(): Inizialize...");
            var sql = this._formacionPrincipalQuery.ObtenerFormacionPrincipalId(id);
            var resultado = await this._dbMysqlServerContext.HHRRFormacionPrincipal.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"FormacionPrincipalRepository/ObtenerFormacionPrincipalId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"FormacionPrincipalRepository/ObtenerFormacionPrincipalId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRFormacionPrincipal>> CrearFormacionPrincipalId(string NombreFormacionPrincipal)
        {
            this._logger.LogWarning($"FormacionPrincipalRepository/CrearFormacionPrincipalId(): Inizialize...");
            var sql = this._formacionPrincipalQuery.GuardarFormacionPrincipal(NombreFormacionPrincipal);
            var resultado = await this._dbMysqlServerContext.HHRRFormacionPrincipal.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"FormacionPrincipalRepository/CrearFormacionPrincipalId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"FormacionPrincipalRepository/CrearFormacionPrincipalId: Message => 'No existe pudo crear Tipo Documento' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRFormacionPrincipal>> ModificarFormacionPrincipal(string NombreFormacionPrincipal, int id)
        {
            this._logger.LogWarning($"FormacionPrincipalRepository/UpdateFormacionPrincipal(): Inizialize...");
            var sql = this._formacionPrincipalQuery.ModificarFormacionPrincipal(NombreFormacionPrincipal, id);
            var resultado = await this._dbMysqlServerContext.HHRRFormacionPrincipal.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"FormacionPrincipalRepository/ModificarFormacionPrincipal SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"FormacionPrincipalRepository/ModificarFormacionPrincipal: Message => 'No puso modificar' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRFormacionPrincipal>> EliminarFormacionPrincipal(int id)
        {
            this._logger.LogWarning($"FormacionPrincipalRepository/EliminarFormacionPrincipal(): Inizialize...");
            var sql = this._formacionPrincipalQuery.EliminarFormacionPrincipal(id);
            var resultado = await this._dbMysqlServerContext.HHRRFormacionPrincipal.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"FormacionPrincipalRepository/EliminarFormacionPrincipal SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"FormacionPrincipalRepository/EliminarFormacionPrincipal: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
    }
}