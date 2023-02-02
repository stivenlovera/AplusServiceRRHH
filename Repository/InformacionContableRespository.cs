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
    public class InformacionContableRepository
    {
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly ILogger<InformacionContableRepository> _logger;
        private readonly InformacionContableQuery _informacionContableQuery;

        public InformacionContableRepository(
            DbMysqlServerContext DbMysqlServerContext,
            ILogger<InformacionContableRepository> logger,
            InformacionContableQuery informacionContableQuery
        )
        {
            this._dbMysqlServerContext = DbMysqlServerContext;
            this._logger = logger;
            this._informacionContableQuery = informacionContableQuery;
        }
        public async Task<List<HHRRInformacionContable>> ObtenerInformacionContables()
        {
            this._logger.LogWarning($"InformacionContableRepositorio/ObtenerInformacionContables(): Inizialize...");
            var sql = this._informacionContableQuery.ObtenerInformacionContable();
            var resultado = await this._dbMysqlServerContext.HHRRInformacionContable.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"InformacionContableRepositorio/ObtenerInformacionContables SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"InformacionContableRepositorio/ObtenerInformacionContables: Message => 'Error al buscar InformacionContables' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRInformacionContable>> ObtenerInformacionContableId(int id)
        {
            this._logger.LogWarning($"InformacionContableRepository/ObtenerInformacionContableId(): Inizialize...");
            var sql = this._informacionContableQuery.ObtenerInformacionContableId(id);
            var resultado = await this._dbMysqlServerContext.HHRRInformacionContable.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"InformacionContableRepository/ObtenerInformacionContableId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"InformacionContableRepository/ObtenerInformacionContableId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRInformacionContable>> CrearInformacionContableId(string NombreInformacionContable)
        {
            this._logger.LogWarning($"InformacionContableRepository/CrearInformacionContableId(): Inizialize...");
            var sql = this._informacionContableQuery.GuardarInformacionContable(NombreInformacionContable);
            var resultado = await this._dbMysqlServerContext.HHRRInformacionContable.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"InformacionContableRepository/CrearInformacionContableId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"InformacionContableRepository/CrearInformacionContableId: Message => 'No existe pudo crear Tipo Documento' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRInformacionContable>> ModificarInformacionContable(string NombreInformacionContable, int id)
        {
            this._logger.LogWarning($"InformacionContableRepository/UpdateInformacionContable(): Inizialize...");
            var sql = this._informacionContableQuery.ModificarInformacionContable(NombreInformacionContable, id);
            var resultado = await this._dbMysqlServerContext.HHRRInformacionContable.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"InformacionContableRepository/ModificarInformacionContable SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"InformacionContableRepository/ModificarInformacionContable: Message => 'No puso modificar' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRInformacionContable>> EliminarInformacionContable(int id)
        {
            this._logger.LogWarning($"InformacionContableRepository/EliminarInformacionContable(): Inizialize...");
            var sql = this._informacionContableQuery.EliminarInformacionContable(id);
            var resultado = await this._dbMysqlServerContext.HHRRInformacionContable.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"InformacionContableRepository/EliminarInformacionContable SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"InformacionContableRepository/EliminarInformacionContable: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
    }
}