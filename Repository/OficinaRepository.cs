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
                this._logger.LogError($"OficinaRepositorio/ObtenerOficina: Message => 'Error al buscar Oficina' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRROficina>> ObtenerOficinaId(int id)
        {
            this._logger.LogWarning($"OficinaRepository/ObtenerOficinaId(): Inizialize...");
            var sql = this._oficinaQuery.ObtenerOficinaId(id);
            var resultado = await this._dbMysqlServerContext.HHRROficina.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"OficinaRepository/ObtenerOficinaId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"OficinaRepository/ObtenerOficinaId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRROficina>> CrearOficina(string NombreOficina, int sucursalId)
        {
            this._logger.LogWarning($"OficinaRepository/CrearOficinaId(): Inizialize...");
            var sql = this._oficinaQuery.GuardarOficina(NombreOficina, sucursalId);
            var resultado = await this._dbMysqlServerContext.HHRROficina.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"OficinaRepository/CrearOficinaId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"OficinaRepository/CrearOficinaId: Message => 'No existe pudo crear Tipo Documento' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRROficina>> ModificarOficina(string NombreOficina, int sucursalId, int id)
        {
            this._logger.LogWarning($"OficinaRepository/UpdateOficina(): Inizialize...");
            var sql = this._oficinaQuery.ModificarOficina(NombreOficina, sucursalId, id);
            var resultado = await this._dbMysqlServerContext.HHRROficina.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"OficinaRepository/ModificarOficina SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"OficinaRepository/ModificarOficina: Message => 'No puso modificar' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRROficina>> EliminarOficina(int id)
        {
            this._logger.LogWarning($"OficinaRepository/EliminarOficina(): Inizialize...");
            var sql = this._oficinaQuery.EliminarOficina(id);
            var resultado = await this._dbMysqlServerContext.HHRROficina.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"OficinaRepository/EliminarOficina SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"OficinaRepository/EliminarOficina: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
    }
}