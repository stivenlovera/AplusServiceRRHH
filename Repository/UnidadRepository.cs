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
    public class UnidadRepository
    {
        private readonly ILogger<UnidadRepository> _logger;
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly UnidadQuery _UnidadQuery;

        public UnidadRepository(
            ILogger<UnidadRepository> logger,
            DbMysqlServerContext dbMysqlServerContext,
            UnidadQuery UnidadQuery
        )
        {
            this._logger = logger;
            this._dbMysqlServerContext = dbMysqlServerContext;
            this._UnidadQuery = UnidadQuery;
        }
        public async Task<List<HHRRUnidad>> ObtenerUnidad()
        {
            this._logger.LogWarning($"UnidadRepository/ObtenerUnidad(): Inizialize...");
            var sql = this._UnidadQuery.ObtenerUnidad();
            var resultado = await this._dbMysqlServerContext.HHRRUnidad.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"UnidadRepository/ObtenerUnidad SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"UnidadRepository/ObtenerUnidad: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<HHRRUnidad> ObtenerUnidadId(int id)
        {
            this._logger.LogWarning($"UnidadRepository/ObtenerUnidadId(): Inizialize...");
            var sql = this._UnidadQuery.ObtenerUnidadId(id);
            var data = await this._dbMysqlServerContext.HHRRUnidad.FromSqlRaw(sql).ToListAsync();
            var resultado = data.FirstOrDefault();
            if (resultado != null)
            {
                this._logger.LogWarning($"UnidadRepository/ObtenerUnidadId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"UnidadRepository/ObtenerUnidadId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<bool> CrearUnidadId(string NombreUnidad)
        {
            this._logger.LogWarning($"UnidadRepository/CrearUnidadId(): Inizialize...");
            var sql = this._UnidadQuery.GuardarUnidad(NombreUnidad);
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado == 1)
            {
                this._logger.LogWarning($"UnidadRepository/CrearUnidadId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"UnidadRepository/CrearUnidadId: Message => 'No existe pudo crear Unidad' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<bool> ModificarUnidad(string NombreUnidad, int id)
        {
            this._logger.LogWarning($"UnidadRepository/UpdateUnidad(): Inizialize...");
            var sql = this._UnidadQuery.ModificarUnidad(NombreUnidad, id);
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado == 1)
            {
                this._logger.LogWarning($"UnidadRepository/ModificarUnidad SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"UnidadRepository/ModificarUnidad: Message => 'No puso Añadir' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<bool> EliminarUnidad(int id)
        {
            this._logger.LogWarning($"UnidadRepository/EliminarUnidad(): Inizialize...");
            var sql = this._UnidadQuery.EliminarUnidad(id);
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado == 1)
            {
                this._logger.LogWarning($"UnidadRepository/EliminarUnidad SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"UnidadRepository/EliminarUnidad: Message => 'Error al eliminar Unidad' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
    }
}