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
                this._logger.LogError($"TipoContratoRepositorio/ObtenerTipoContratos: Message => 'Error se pudo obtener tipo contrato' CONSULT => {sql}");
                throw new Exception("No se pudo obtener tipo contrato");
            }
        }
        public async Task<HHRRTipoContrato> ObtenerTipoContratoId(int id)
        {
            this._logger.LogWarning($"TipoContratoRepository/ObtenerTipoContratoId({id}): Inizialize...");
            var sql = this._tipoContratoQuery.ObtenerTipoContratoId(id);
            var data = await this._dbMysqlServerContext.HHRRTipoContrato.FromSqlRaw(sql).ToListAsync();
            var resultado = data.FirstOrDefault();
            if (resultado != null)
            {
                this._logger.LogWarning($"TipoContratoRepository/ObtenerTipoContratoId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"TipoContratoRepository/ObtenerTipoContratoId: Message => 'No se pudo obtener un tipo contrato' CONSULT => {sql}");
                throw new Exception("No no se pudo obtener tipo contrato");
            }
        }
        public async Task<bool> CrearTipoContrato(string NombreTipoContrato)
        {
            this._logger.LogWarning($"TipoContratoRepository/CrearTipoContrato({NombreTipoContrato}): Inizialize...");
            var sql = this._tipoContratoQuery.GuardarTipoContrato(NombreTipoContrato);
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado == 1)
            {
                this._logger.LogWarning($"TipoContratoRepository/CrearTipoContrato SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"TipoContratoRepository/CrearTipoContrato: Message => 'No se pudo registrar tipo contrato' CONSULT => {sql}");
                throw new Exception("No se pudo registrar tipo");
            }
        }
        public async Task<bool> ModificarTipoContrato(string NombreTipoContrato, int id)
        {
            this._logger.LogWarning($"TipoContratoRepository/ModificarTipoContrato({NombreTipoContrato}, {id}): Inizialize...");
            var sql = this._tipoContratoQuery.ModificarTipoContrato(NombreTipoContrato, id);
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado == 1 )
            {
                this._logger.LogWarning($"TipoContratoRepository/ModificarTipoContrato SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"TipoContratoRepository/ModificarTipoContrato: Message => 'No se pudo modificar' CONSULT => {sql}");
                throw new Exception("No se pudo modificar");
            }
        }
        public async Task<bool> EliminarTipoContrato(int id)
        {
            this._logger.LogWarning($"TipoContratoRepository/EliminarTipoContrato({id}): Inizialize...");
            var sql = this._tipoContratoQuery.EliminarTipoContrato(id);
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado ==1)
            {
                this._logger.LogWarning($"TipoContratoRepository/EliminarTipoContrato SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"TipoContratoRepository/EliminarTipoContrato: Message => 'No existe Eliminar tipo contrato' CONSULT => {sql}");
                throw new Exception("No se pudo eliminar");
            }
        }
    }
}