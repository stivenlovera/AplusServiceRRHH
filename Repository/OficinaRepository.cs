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
    public class OficinaRepository
    {
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly ILogger<OficinaRepository> _logger;
        private readonly OficinaQuery _oficinaQuery;

        public OficinaRepository(
            DbMysqlServerContext DbMysqlServerContext,
            ILogger<OficinaRepository> logger,
            OficinaQuery oficinaQuery
        )
        {
            this._dbMysqlServerContext = DbMysqlServerContext;
            this._logger = logger;
            this._oficinaQuery = oficinaQuery;
        }
        public async Task<List<HHRROficina>> ObtenerOficina()
        {
            this._logger.LogWarning($"OficinaRepositorio/ObtenerOficina(): Inizialize...");
            var sql = this._oficinaQuery.ObtenerOficina();
            var resultado = await this._dbMysqlServerContext.HHRROficina.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"OficinaRepositorio/ObtenerOficina SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"OficinaRepositorio/ObtenerOficina: Message => 'Error al obtener oficina' CONSULT => {sql}");
                throw new Exception("No se pudo obtener oficina");
            }
        }
        public async Task<HHRROficina> ObtenerOficinaId(int id)
        {
            this._logger.LogWarning($"OficinaRepository/ObtenerOficinaId({id}): Inizialize...");
            var sql = this._oficinaQuery.ObtenerOficinaId(id);
            var data = await this._dbMysqlServerContext.HHRROficina.FromSqlRaw(sql).ToListAsync();
            var resultado = data.FirstOrDefault();
            if (resultado != null)
            {
                this._logger.LogWarning($"OficinaRepository/ObtenerOficinaId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"OficinaRepository/ObtenerOficinaId: Message => 'No se pudo obtener oficina' CONSULT => {sql}");
                throw new Exception("No se pudo obtener oficina");
            }
        }
        public async Task<bool> CrearOficina(string NombreOficina, int sucursalId)
        {
            this._logger.LogWarning($"OficinaRepository/CrearOficinaId({NombreOficina},{sucursalId}): Inizialize...");
            var sql = this._oficinaQuery.GuardarOficina(NombreOficina, sucursalId);
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado == 1)
            {
                this._logger.LogWarning($"OficinaRepository/CrearOficinaId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"OficinaRepository/CrearOficinaId: Message => 'No existe pudo crear Tipo Documento' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<bool> ModificarOficina(string NombreOficina, int sucursalId, int id)
        {
            this._logger.LogWarning($"OficinaRepository/UpdateOficina({NombreOficina},{sucursalId},{id}): Inizialize...");
            var sql = this._oficinaQuery.ModificarOficina(NombreOficina, sucursalId, id);
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado == 1)
            {
                this._logger.LogWarning($"OficinaRepository/ModificarOficina SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"OficinaRepository/ModificarOficina: Message => 'No puso modificar' CONSULT => {sql}");
                throw new Exception("No se pudo modificar oficina");
            }
        }
        public async Task<bool> EliminarOficina(int id)
        {
            this._logger.LogWarning($"OficinaRepository/EliminarOficina({id}): Inizialize...");
            var sql = this._oficinaQuery.EliminarOficina(id);
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado == 1)
            {
                this._logger.LogWarning($"OficinaRepository/EliminarOficina SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"OficinaRepository/EliminarOficina: Message => 'No se puede eliminar' CONSULT => {sql}");
                throw new Exception("No se puede eliminar");
            }
        }
    }
}