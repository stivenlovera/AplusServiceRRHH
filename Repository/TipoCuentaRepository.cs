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
    public class TipoCuentaRepository
    {
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly ILogger<TipoCuentaRepository> _logger;
        private readonly TipoCuentaQuery _tipoCuentaQuery;

        public TipoCuentaRepository(
            DbMysqlServerContext DbMysqlServerContext,
            ILogger<TipoCuentaRepository> logger,
            TipoCuentaQuery tipoCuentaQuery
        )
        {
            this._dbMysqlServerContext = DbMysqlServerContext;
            this._logger = logger;
            this._tipoCuentaQuery = tipoCuentaQuery;
        }
        public async Task<List<HHRRTipoCuenta>> ObtenerTipoCuentas()
        {
            this._logger.LogWarning($"TipoCuentaRepositorio/ObtenerTipoCuentas(): Inizialize...");
            var sql = this._tipoCuentaQuery.ObtenerTipoCuenta();
            var resultado = await this._dbMysqlServerContext.HHRRTipoCuenta.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"TipoCuentaRepositorio/ObtenerTipoCuentas SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"TipoCuentaRepositorio/ObtenerTipoCuentas: Message => 'Error al buscar TipoCuentas' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRTipoCuenta>> ObtenerTipoCuentaId(int id)
        {
            this._logger.LogWarning($"TipoCuentaRepository/ObtenerTipoCuentaId(): Inizialize...");
            var sql = this._tipoCuentaQuery.ObtenerTipoCuentaId(id);
            var resultado = await this._dbMysqlServerContext.HHRRTipoCuenta.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"TipoCuentaRepository/ObtenerTipoCuentaId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"TipoCuentaRepository/ObtenerTipoCuentaId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRTipoCuenta>> CrearTipoCuentaId(string NombreTipoCuenta)
        {
            this._logger.LogWarning($"TipoCuentaRepository/CrearTipoCuentaId(): Inizialize...");
            var sql = this._tipoCuentaQuery.GuardarTipoCuenta(NombreTipoCuenta);
            var resultado = await this._dbMysqlServerContext.HHRRTipoCuenta.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"TipoCuentaRepository/CrearTipoCuentaId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"TipoCuentaRepository/CrearTipoCuentaId: Message => 'No existe pudo crear Tipo Documento' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRTipoCuenta>> ModificarTipoCuenta(string NombreTipoCuenta, int id)
        {
            this._logger.LogWarning($"TipoCuentaRepository/UpdateTipoCuenta(): Inizialize...");
            var sql = this._tipoCuentaQuery.ModificarTipoCuenta(NombreTipoCuenta, id);
            var resultado = await this._dbMysqlServerContext.HHRRTipoCuenta.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"TipoCuentaRepository/ModificarTipoCuenta SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"TipoCuentaRepository/ModificarTipoCuenta: Message => 'No puso modificar' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRTipoCuenta>> EliminarTipoCuenta(int id)
        {
            this._logger.LogWarning($"TipoCuentaRepository/EliminarTipoCuenta(): Inizialize...");
            var sql = this._tipoCuentaQuery.EliminarTipoCuenta(id);
            var resultado = await this._dbMysqlServerContext.HHRRTipoCuenta.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"TipoCuentaRepository/EliminarTipoCuenta SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"TipoCuentaRepository/EliminarTipoCuenta: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
    }
}