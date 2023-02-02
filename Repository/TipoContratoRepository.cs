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
    public class TipoContratoRepository
    {
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly ILogger<TipoContratoRepository> _logger;
        private readonly TipoContratoQuery _tipoContratoQuery;

        public TipoContratoRepository(
            DbMysqlServerContext DbMysqlServerContext,
            ILogger<TipoContratoRepository> logger,
            TipoContratoQuery tipoContratoQuery
        )
        {
            this._dbMysqlServerContext = DbMysqlServerContext;
            this._logger = logger;
            this._tipoContratoQuery = tipoContratoQuery;
        }
        public async Task<List<HHRRTipoContrato>> ObtenerTipoContratos()
        {
            this._logger.LogWarning($"TipoContratoRepositorio/ObtenerTipoContratos(): Inizialize...");
            var sql = this._tipoContratoQuery.ObtenerTipoContrato();
            var resultado = await this._dbMysqlServerContext.HHRRTipoContrato.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"TipoContratoRepositorio/ObtenerTipoContratos SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"TipoContratoRepositorio/ObtenerTipoContratos: Message => 'Error al buscar TipoContratos' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRTipoContrato>> ObtenerTipoContratoId(int id)
        {
            this._logger.LogWarning($"TipoContratoRepository/ObtenerTipoContratoId(): Inizialize...");
            var sql = this._tipoContratoQuery.ObtenerTipoContratoId(id);
            var resultado = await this._dbMysqlServerContext.HHRRTipoContrato.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"TipoContratoRepository/ObtenerTipoContratoId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"TipoContratoRepository/ObtenerTipoContratoId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRTipoContrato>> CrearTipoContratoId(string NombreTipoContrato)
        {
            this._logger.LogWarning($"TipoContratoRepository/CrearTipoContratoId(): Inizialize...");
            var sql = this._tipoContratoQuery.GuardarTipoContrato(NombreTipoContrato);
            var resultado = await this._dbMysqlServerContext.HHRRTipoContrato.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"TipoContratoRepository/CrearTipoContratoId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"TipoContratoRepository/CrearTipoContratoId: Message => 'No existe pudo crear Tipo Documento' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRTipoContrato>> ModificarTipoContrato(string NombreTipoContrato, int id)
        {
            this._logger.LogWarning($"TipoContratoRepository/UpdateTipoContrato(): Inizialize...");
            var sql = this._tipoContratoQuery.ModificarTipoContrato(NombreTipoContrato, id);
            var resultado = await this._dbMysqlServerContext.HHRRTipoContrato.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"TipoContratoRepository/ModificarTipoContrato SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"TipoContratoRepository/ModificarTipoContrato: Message => 'No puso modificar' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRTipoContrato>> EliminarTipoContrato(int id)
        {
            this._logger.LogWarning($"TipoContratoRepository/EliminarTipoContrato(): Inizialize...");
            var sql = this._tipoContratoQuery.EliminarTipoContrato(id);
            var resultado = await this._dbMysqlServerContext.HHRRTipoContrato.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"TipoContratoRepository/EliminarTipoContrato SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"TipoContratoRepository/EliminarTipoContrato: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
    }
}