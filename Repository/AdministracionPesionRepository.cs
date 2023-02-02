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
    public class AdministracionPesionRepository
    {
        private readonly ILogger<AdministracionPesionRepository> _logger;
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly AdministracionPesionQuery _administracionPesionQuery;

        public AdministracionPesionRepository(
            ILogger<AdministracionPesionRepository> logger,
            DbMysqlServerContext dbMysqlServerContext,
            AdministracionPesionQuery administracionPesionQuery
        )
        {
            this._logger = logger;
            this._dbMysqlServerContext = dbMysqlServerContext;
            this._administracionPesionQuery = administracionPesionQuery;
        }
        public async Task<List<HHRRAdministracionPesion>> ObtenerAdministracionPesion()
        {
            this._logger.LogWarning($"AdministracionPesionRepository/ObtenerAdministracionPesion(): Inizialize...");
            var sql = this._administracionPesionQuery.ObtenerAdministracionPesion();
            var resultado = await this._dbMysqlServerContext.HHRRAdministracionPesion.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"AdministracionPesionRepository/ObtenerAdministracionPesion SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"AdministracionPesionRepository/ObtenerAdministracionPesion: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRAdministracionPesion>> ObtenerAdministracionPesionId(int id)
        {
            this._logger.LogWarning($"AdministracionPesionRepository/ObtenerAdministracionPesionId(): Inizialize...");
            var sql = this._administracionPesionQuery.ObtenerAdministracionPesionId(id);
            var resultado = await this._dbMysqlServerContext.HHRRAdministracionPesion.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"AdministracionPesionRepository/ObtenerAdministracionPesionId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"AdministracionPesionRepository/ObtenerAdministracionPesionId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRAdministracionPesion>> CrearAdministracionPesionId(string NombreAdministracionPesion)
        {
            this._logger.LogWarning($"AdministracionPesionRepository/CrearAdministracionPesionId(): Inizialize...");
            var sql = this._administracionPesionQuery.GuardarAdministracionPesion(NombreAdministracionPesion);
            var resultado = await this._dbMysqlServerContext.HHRRAdministracionPesion.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"AdministracionPesionRepository/CrearAdministracionPesionId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"AdministracionPesionRepository/CrearAdministracionPesionId: Message => 'No existe pudo crear Tipo Documento' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRAdministracionPesion>> ModificarAdministracionPesion(string NombreAdministracionPesion, int id)
        {
            this._logger.LogWarning($"AdministracionPesionRepository/UpdateAdministracionPesion(): Inizialize...");
            var sql = this._administracionPesionQuery.ModificarAdministracionPesion(NombreAdministracionPesion, id);
            var resultado = await this._dbMysqlServerContext.HHRRAdministracionPesion.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"AdministracionPesionRepository/ModificarAdministracionPesion SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"AdministracionPesionRepository/ModificarAdministracionPesion: Message => 'No puso modificar' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRAdministracionPesion>> EliminarAdministracionPesion(int id)
        {
            this._logger.LogWarning($"AdministracionPesionRepository/EliminarAdministracionPesion(): Inizialize...");
            var sql = this._administracionPesionQuery.EliminarAdministracionPesion(id);
            var resultado = await this._dbMysqlServerContext.HHRRAdministracionPesion.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"AdministracionPesionRepository/EliminarAdministracionPesion SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"AdministracionPesionRepository/EliminarAdministracionPesion: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
    }
}