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
    public class CentroCostoRepository
    {
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly ILogger<CentroCostoRepository> _logger;
        private readonly CentroCostoQuery _centroCostoQuery;

        public CentroCostoRepository(
            DbMysqlServerContext DbMysqlServerContext,
            ILogger<CentroCostoRepository> logger,
            CentroCostoQuery centroCostoQuery
        )
        {
            this._dbMysqlServerContext = DbMysqlServerContext;
            this._logger = logger;
            this._centroCostoQuery = centroCostoQuery;
        }
        public async Task<List<HHRRCentroCosto>> ObtenerCentroCostos()
        {
            this._logger.LogWarning($"CentroCostoRepository/ObtenerCentroCostos(): Inizialize...");
            var sql = this._centroCostoQuery.ObtenerCentroCosto();
            var resultado = await this._dbMysqlServerContext.HHRRCentroCosto.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"CentroCostoRepository/ObtenerCentroCostos SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"CentroCostoRepository/ObtenerCentroCostos: Message => 'Error al buscar CentroCostos' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRCentroCosto>> ObtenerCentroCostoId(int id)
        {
            this._logger.LogWarning($"CentroCostoRepository/ObtenerCentroCostoId(): Inizialize...");
            var sql = this._centroCostoQuery.ObtenerCentroCostoId(id);
            var resultado = await this._dbMysqlServerContext.HHRRCentroCosto.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"CentroCostoRepository/ObtenerCentroCostoId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"CentroCostoRepository/ObtenerCentroCostoId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRCentroCosto>> CrearCentroCostoId(string NombreCentroCosto)
        {
            this._logger.LogWarning($"CentroCostoRepository/CrearCentroCostoId(): Inizialize...");
            var sql = this._centroCostoQuery.GuardarCentroCosto(NombreCentroCosto);
            var resultado = await this._dbMysqlServerContext.HHRRCentroCosto.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"CentroCostoRepository/CrearCentroCostoId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"CentroCostoRepository/CrearCentroCostoId: Message => 'No existe pudo crear Tipo Documento' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRCentroCosto>> ModificarCentroCosto(string NombreCentroCosto, int id)
        {
            this._logger.LogWarning($"CentroCostoRepository/UpdateCentroCosto(): Inizialize...");
            var sql = this._centroCostoQuery.ModificarCentroCosto(NombreCentroCosto, id);
            var resultado = await this._dbMysqlServerContext.HHRRCentroCosto.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"CentroCostoRepository/ModificarCentroCosto SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"CentroCostoRepository/ModificarCentroCosto: Message => 'No puso modificar' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRCentroCosto>> EliminarCentroCosto(int id)
        {
            this._logger.LogWarning($"CentroCostoRepository/EliminarCentroCosto(): Inizialize...");
            var sql = this._centroCostoQuery.EliminarCentroCosto(id);
            var resultado = await this._dbMysqlServerContext.HHRRCentroCosto.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"CentroCostoRepository/EliminarCentroCosto SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"CentroCostoRepository/EliminarCentroCosto: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
    }
}