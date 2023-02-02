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
    public class SucursalRepository
    {
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly ILogger<SucursalRepository> _logger;
        private readonly SucursalQuery _sucursalQuery;

        public SucursalRepository(
            DbMysqlServerContext DbMysqlServerContext,
            ILogger<SucursalRepository> logger,
            SucursalQuery sucursalQuery
        )
        {
            this._dbMysqlServerContext = DbMysqlServerContext;
            this._logger = logger;
            this._sucursalQuery =sucursalQuery;
        }
        public async Task<List<HHRRSucursal>> ObtenerSucursal()
        {
            this._logger.LogWarning($"SucursalRepository/ObtenerSucursal(): Inizialize...");
            var sql = this._sucursalQuery.ObtenerSucursal();
            var resultado = await this._dbMysqlServerContext.HHRRSucursal.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"SucursalRepository/ObtenerSucursal SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"SucursalRepository/ObtenerSucursal: Message => 'Error al buscar Sucursal' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRSucursal>> ObtenerSucursalId(int id)
        {
            this._logger.LogWarning($"SucursalRepository/ObtenerSucursalId(): Inizialize...");
            var sql = this._sucursalQuery.ObtenerSucursalId(id);
            var resultado = await this._dbMysqlServerContext.HHRRSucursal.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"SucursalRepository/ObtenerSucursalId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"SucursalRepository/ObtenerSucursalId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRSucursal>> CrearSucursal(string NombreSucursal,string Dirrecion)
        {
            this._logger.LogWarning($"SucursalRepository/CrearSucursalId(): Inizialize...");
            var sql = this._sucursalQuery.GuardarSucursal(NombreSucursal,Dirrecion);
            var resultado = await this._dbMysqlServerContext.HHRRSucursal.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"SucursalRepository/CrearSucursalId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"SucursalRepository/CrearSucursalId: Message => 'No existe pudo crear Tipo Documento' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRSucursal>> ModificarSucursal(string NombreSucursal,string Dirrecion, int id)
        {
            this._logger.LogWarning($"SucursalRepository/UpdateSucursal(): Inizialize...");
            var sql = this._sucursalQuery.ModificarSucursal(NombreSucursal,Dirrecion, id);
            var resultado = await this._dbMysqlServerContext.HHRRSucursal.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"SucursalRepository/ModificarSucursal SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"SucursalRepository/ModificarSucursal: Message => 'No puso modificar' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRSucursal>> EliminarSucursal(int id)
        {
            this._logger.LogWarning($"SucursalRepository/EliminarSucursal(): Inizialize...");
            var sql = this._sucursalQuery.EliminarSucursal(id);
            var resultado = await this._dbMysqlServerContext.HHRRSucursal.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"SucursalRepository/EliminarSucursal SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"SucursalRepository/EliminarSucursal: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
    }
}