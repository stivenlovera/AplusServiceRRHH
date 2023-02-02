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
    public class TipoDocumentoRepository
    {
        private readonly ILogger<TipoDocumentoRepository> _logger;
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly TipoDocumentoQuery _tipoDocumentoQuery;

        public TipoDocumentoRepository(
            ILogger<TipoDocumentoRepository> logger,
            DbMysqlServerContext dbMysqlServerContext,
            TipoDocumentoQuery TipoDocumentoQuery
        )
        {
            this._logger = logger;
            this._dbMysqlServerContext = dbMysqlServerContext;
            this._tipoDocumentoQuery = TipoDocumentoQuery;
        }
        public async Task<List<HHRRTipoDocumento>> ObtenerTipoDocumento()
        {
            this._logger.LogWarning($"TipoDocumentoRepository/ObtenerTipoDocumento(): Inizialize...");
            var sql = this._tipoDocumentoQuery.ObtenerTipoDocumento();
            var resultado = await this._dbMysqlServerContext.HHRRTipoDocumento.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"TipoDocumentoRepository/ObtenerTipoDocumento SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"TipoDocumentoRepository/ObtenerTipoDocumento: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRTipoDocumento>> ObtenerTipoDocumentoId(int id)
        {
            this._logger.LogWarning($"TipoDocumentoRepository/ObtenerTipoDocumentoId(): Inizialize...");
            var sql = this._tipoDocumentoQuery.ObtenerTipoDocumentoId(id);
            var resultado = await this._dbMysqlServerContext.HHRRTipoDocumento.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"TipoDocumentoRepository/ObtenerTipoDocumentoId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"TipoDocumentoRepository/ObtenerTipoDocumentoId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRTipoDocumento>> CrearTipoDocumentoId(string NombreTipoDocumento)
        {
            this._logger.LogWarning($"TipoDocumentoRepository/CrearTipoDocumentoId(): Inizialize...");
            var sql = this._tipoDocumentoQuery.GuardarTipoDocumento(NombreTipoDocumento);
            var resultado = await this._dbMysqlServerContext.HHRRTipoDocumento.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"TipoDocumentoRepository/CrearTipoDocumentoId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"TipoDocumentoRepository/CrearTipoDocumentoId: Message => 'No existe pudo crear Tipo Documento' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRTipoDocumento>> ModificarTipoDocumento(string NombreTipoDocumento, int id)
        {
            this._logger.LogWarning($"TipoDocumentoRepository/UpdateTipoDocumento(): Inizialize...");
            var sql = this._tipoDocumentoQuery.ModificarTipoDocumento(NombreTipoDocumento, id);
            var resultado = await this._dbMysqlServerContext.HHRRTipoDocumento.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"TipoDocumentoRepository/ModificarTipoDocumento SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"TipoDocumentoRepository/ModificarTipoDocumento: Message => 'No puso modificar' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRTipoDocumento>> EliminarTipoDocumento(int id)
        {
            this._logger.LogWarning($"TipoDocumentoRepository/EliminarTipoDocumento(): Inizialize...");
            var sql = this._tipoDocumentoQuery.EliminarTipoDocumento(id);
            var resultado = await this._dbMysqlServerContext.HHRRTipoDocumento.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"TipoDocumentoRepository/EliminarTipoDocumento SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"TipoDocumentoRepository/EliminarTipoDocumento: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
    }
}