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
            this._sucursalQuery = sucursalQuery;
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
                throw new Exception("No se pudo obtener sucursales");
            }
        }
        public async Task<HHRRSucursal> ObtenerSucursalId(int id)
        {
            this._logger.LogWarning($"SucursalRepository/ObtenerSucursalId({id}): Inizialize...");
            var sql = this._sucursalQuery.ObtenerSucursalId(id);
            var data = await this._dbMysqlServerContext.HHRRSucursal.FromSqlRaw(sql).ToListAsync();
            var resultado = data.FirstOrDefault();
            if (resultado != null)
            {
                this._logger.LogWarning($"SucursalRepository/ObtenerSucursalId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"SucursalRepository/ObtenerSucursalId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No obtener la sucursal");
            }
        }
        public async Task<bool> CrearSucursal(string NombreSucursal, string Dirrecion)
        {
            this._logger.LogWarning($"SucursalRepository/CrearSucursal({NombreSucursal},{Dirrecion}): Inizialize...");
            var sql = this._sucursalQuery.GuardarSucursal(NombreSucursal, Dirrecion);
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado == 1)
            {
                this._logger.LogWarning($"SucursalRepository/CrearSucursal SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"SucursalRepository/CrearSucursal: Message => 'No existe pudo crear sucursal' CONSULT => {sql}");
                throw new Exception("No se pudo crear sucusal");
            }
        }
        public async Task<bool> ModificarSucursal(string NombreSucursal, string Dirrecion, int id)
        {
            this._logger.LogWarning($"SucursalRepository/UpdateSucursal({NombreSucursal},{Dirrecion},{id}): Inizialize...");
            var sql = this._sucursalQuery.ModificarSucursal(NombreSucursal, Dirrecion, id);
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado == 1)
            {
                this._logger.LogWarning($"SucursalRepository/ModificarSucursal SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"SucursalRepository/ModificarSucursal: Message => 'No puso modificar sucursal' CONSULT => {sql}");
                throw new Exception("No se pudo crear sucursal");
            }
        }
        public async Task<bool> EliminarSucursal(int id)
        {
            this._logger.LogWarning($"SucursalRepository/EliminarSucursal({id}): Inizialize...");
            var sql = this._sucursalQuery.EliminarSucursal(id);
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);

            if (resultado ==1)
            {
                this._logger.LogWarning($"SucursalRepository/EliminarSucursal SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"SucursalRepository/EliminarSucursal: Message => 'No se pudo eliminar Sucursal' CONSULT => {sql}");
                throw new Exception("No se pudo eliminar Sucursal");
            }
        }
    }
}