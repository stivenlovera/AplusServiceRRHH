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
    public class FormaPagoRepository
    {
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly ILogger<FormaPagoRepository> _logger;
        private readonly FormaPagoQuery _formaPagoQuery;

        public FormaPagoRepository(
            DbMysqlServerContext DbMysqlServerContext,
            ILogger<FormaPagoRepository> logger,
            FormaPagoQuery formaPagoQuery
        )
        {
            this._dbMysqlServerContext = DbMysqlServerContext;
            this._logger = logger;
            this._formaPagoQuery = formaPagoQuery;
        }
        public async Task<List<HHRRFormaPago>> ObtenerFormaPagos()
        {
            this._logger.LogWarning($"FormaPagoRepository/ObtenerFormaPagos(): Inizialize...");
            var sql = this._formaPagoQuery.ObtenerFormaPago();
            var resultado = await this._dbMysqlServerContext.HHRRFormaPago.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"FormaPagoRepository/ObtenerFormaPagos SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"FormaPagoRepository/ObtenerFormaPagos: Message => 'Error al buscar FormaPagos' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRFormaPago>> ObtenerFormaPagoId(int id)
        {
            this._logger.LogWarning($"FormaPagoRepository/ObtenerFormaPagoId(): Inizialize...");
            var sql = this._formaPagoQuery.ObtenerFormaPagoId(id);
            var resultado = await this._dbMysqlServerContext.HHRRFormaPago.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"FormaPagoRepository/ObtenerFormaPagoId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"FormaPagoRepository/ObtenerFormaPagoId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRFormaPago>> CrearFormaPagoId(string NombreFormaPago)
        {
            this._logger.LogWarning($"FormaPagoRepository/CrearFormaPagoId(): Inizialize...");
            var sql = this._formaPagoQuery.GuardarFormaPago(NombreFormaPago);
            var resultado = await this._dbMysqlServerContext.HHRRFormaPago.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"FormaPagoRepository/CrearFormaPagoId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"FormaPagoRepository/CrearFormaPagoId: Message => 'No existe pudo crear Tipo Documento' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRFormaPago>> ModificarFormaPago(string NombreFormaPago, int id)
        {
            this._logger.LogWarning($"FormaPagoRepository/UpdateFormaPago(): Inizialize...");
            var sql = this._formaPagoQuery.ModificarFormaPago(NombreFormaPago, id);
            var resultado = await this._dbMysqlServerContext.HHRRFormaPago.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"FormaPagoRepository/ModificarFormaPago SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"FormaPagoRepository/ModificarFormaPago: Message => 'No puso modificar' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRFormaPago>> EliminarFormaPago(int id)
        {
            this._logger.LogWarning($"FormaPagoRepository/EliminarFormaPago(): Inizialize...");
            var sql = this._formaPagoQuery.EliminarFormaPago(id);
            var resultado = await this._dbMysqlServerContext.HHRRFormaPago.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"FormaPagoRepository/EliminarFormaPago SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"FormaPagoRepository/EliminarFormaPago: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
    }
}