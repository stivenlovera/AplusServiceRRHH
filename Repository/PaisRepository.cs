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
    public class PaisRepository
    {
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly ILogger<PaisRepository> _logger;
        private readonly PaisQuery _paisQuery;

        public PaisRepository(
            DbMysqlServerContext DbMysqlServerContext,
            ILogger<PaisRepository> logger,
            PaisQuery paisQuery
        )
        {
            this._dbMysqlServerContext = DbMysqlServerContext;
            this._logger = logger;
            this._paisQuery = paisQuery;
        }
        public async Task<List<HHRRPais>> ObtenerPais()
        {
            this._logger.LogWarning($"PaisRepository/ObtenerPais(): Inizialize...");
            var sql = this._paisQuery.ObtenerPais();
            var resultado = await this._dbMysqlServerContext.HHRRPais.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"PaisRepository/ObtenerPais SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"PaisRepository/ObtenerPais: Message => 'Error al buscar Pais' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRPais>> ObtenerPaisId(int id)
        {
            this._logger.LogWarning($"PaisRepository/ObtenerPaisId(): Inizialize...");
            var sql = this._paisQuery.ObtenerPaisId(id);
            var resultado = await this._dbMysqlServerContext.HHRRPais.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"PaisRepository/ObtenerPaisId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"PaisRepository/ObtenerPaisId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRPais>> CrearPaisId(string NombrePais)
        {
            this._logger.LogWarning($"PaisRepository/CrearPaisId(): Inizialize...");
            var sql = this._paisQuery.GuardarPais(NombrePais);
            var resultado = await this._dbMysqlServerContext.HHRRPais.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"PaisRepository/CrearPaisId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"PaisRepository/CrearPaisId: Message => 'No existe pudo crear Tipo Documento' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRPais>> ModificarPais(string NombrePais, int id)
        {
            this._logger.LogWarning($"PaisRepository/UpdatePais(): Inizialize...");
            var sql = this._paisQuery.ModificarPais(NombrePais, id);
            var resultado = await this._dbMysqlServerContext.HHRRPais.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"PaisRepository/ModificarPaisUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"PaisRepository/ModificarPais: Message => 'No puso modificar' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRPais>> EliminarPais(int id)
        {
            this._logger.LogWarning($"PaisRepository/EliminarPais(): Inizialize...");
            var sql = this._paisQuery.EliminarPais(id);
            var resultado = await this._dbMysqlServerContext.HHRRPais.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"PaisRepository/EliminarPaisUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"PaisRepository/EliminarPais: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
    }
}