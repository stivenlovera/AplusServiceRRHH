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
    public class ClasificacionLaboralRepository
    {
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly ILogger<ClasificacionLaboralRepository> _logger;
        private readonly ClasificacionLaboralQuery _clasificacionLaboralQuery;

        public ClasificacionLaboralRepository(
            DbMysqlServerContext DbMysqlServerContext,
            ILogger<ClasificacionLaboralRepository> logger,
            ClasificacionLaboralQuery clasificacionLaboralQuery
        )
        {
            this._dbMysqlServerContext = DbMysqlServerContext;
            this._logger = logger;
            this._clasificacionLaboralQuery = clasificacionLaboralQuery;
        }
        public async Task<List<HHRRClasificacionLaboral>> ObtenerClasificacionLaboral()
        {
            this._logger.LogWarning($"ClasificacionLaboralRepository/ObtenerClasificacionLaboras(): Inizialize...");
            var sql = this._clasificacionLaboralQuery.ObtenerClasificacionLaboral();
            var resultado = await this._dbMysqlServerContext.HHRRClasificacionLaboral.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"ClasificacionLaboralRepository/ObtenerClasificacionLaboras SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"ClasificacionLaboralRepository/ObtenerClasificacionLaboras: Message => 'Error al buscar ClasificacionLaboras' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRClasificacionLaboral>> ObtenerClasificacionLaboralId(int id)
        {
            this._logger.LogWarning($"ClasificacionLaboralRepository/ObtenerClasificacionLaboraId(): Inizialize...");
            var sql = this._clasificacionLaboralQuery.ObtenerClasificacionLaboralId(id);
            var resultado = await this._dbMysqlServerContext.HHRRClasificacionLaboral.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"ClasificacionLaboralRepository/ObtenerClasificacionLaboraId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"ClasificacionLaboralRepository/ObtenerClasificacionLaboraId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRClasificacionLaboral>> CrearClasificacionLaboralId(string NombreClasificacionLabora)
        {
            this._logger.LogWarning($"ClasificacionLaboralRepository/CrearClasificacionLaboraId(): Inizialize...");
            var sql = this._clasificacionLaboralQuery.GuardarClasificacionLaboral(NombreClasificacionLabora);
            var resultado = await this._dbMysqlServerContext.HHRRClasificacionLaboral.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"ClasificacionLaboralRepository/CrearClasificacionLaboraId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"ClasificacionLaboralRepository/CrearClasificacionLaboraId: Message => 'No existe pudo crear Tipo Documento' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRClasificacionLaboral>> ModificarClasificacionLaboralId(string NombreClasificacionLabora, int id)
        {
            this._logger.LogWarning($"ClasificacionLaboralRepository/UpdateClasificacionLabora(): Inizialize...");
            var sql = this._clasificacionLaboralQuery.ModificarClasificacionLaboral(NombreClasificacionLabora, id);
            var resultado = await this._dbMysqlServerContext.HHRRClasificacionLaboral.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"ClasificacionLaboralRepository/ModificarClasificacionLabora SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"ClasificacionLaboralRepository/ModificarClasificacionLabora: Message => 'No puso modificar' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRClasificacionLaboral>> EliminarClasificacionLaboral(int id)
        {
            this._logger.LogWarning($"ClasificacionLaboralRepository/EliminarClasificacionLabora(): Inizialize...");
            var sql = this._clasificacionLaboralQuery.EliminarClasificacionLaboral(id);
            var resultado = await this._dbMysqlServerContext.HHRRClasificacionLaboral.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"ClasificacionLaboralRepository/EliminarClasificacionLabora SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"ClasificacionLaboralRepository/EliminarClasificacionLabora: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
    }
}