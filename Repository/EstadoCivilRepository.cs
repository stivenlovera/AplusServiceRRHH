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
    public class EstadoCivilRepository
    {
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly ILogger<EstadoCivilRepository> _logger;
        private readonly EstadoCivilQuery _estadoCivilQuery;

        public EstadoCivilRepository(
            DbMysqlServerContext DbMysqlServerContext,
            ILogger<EstadoCivilRepository> logger,
            EstadoCivilQuery estadoCivilQuery
        )
        {
            this._dbMysqlServerContext = DbMysqlServerContext;
            this._logger = logger;
            this._estadoCivilQuery = estadoCivilQuery;
        }
        public async Task<List<HHRREstadoCivil>> ObtenerEstadoCivil()
        {
            this._logger.LogWarning($"EstadoCivilRepositorio/ObtenerEstadoCivil(): Inizialize...");
            var sql = this._estadoCivilQuery.ObtenerEstadoCivil();
            var resultado = await this._dbMysqlServerContext.HHRREstadoCivil.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"EstadoCivilRepositorio/ObtenerEstadoCivils SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"EstadoCivilRepositorio/ObtenerEstadoCivils: Message => 'Error al buscar EstadoCivils' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRREstadoCivil>> ObtenerEstadoCivilId(int id)
        {
            this._logger.LogWarning($"EstadoCivilRepository/ObtenerEstadoCivilId(): Inizialize...");
            var sql = this._estadoCivilQuery.ObtenerEstadoCivilId(id);
            var resultado = await this._dbMysqlServerContext.HHRREstadoCivil.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"EstadoCivilRepository/ObtenerEstadoCivilId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"EstadoCivilRepository/ObtenerEstadoCivilId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRREstadoCivil>> CrearEstadoCivilId(string NombreEstadoCivil)
        {
            this._logger.LogWarning($"EstadoCivilRepository/CrearEstadoCivilId(): Inizialize...");
            var sql = this._estadoCivilQuery.GuardarEstadoCivil(NombreEstadoCivil);
            var resultado = await this._dbMysqlServerContext.HHRREstadoCivil.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"EstadoCivilRepository/CrearEstadoCivilId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"EstadoCivilRepository/CrearEstadoCivilId: Message => 'No existe pudo crear Tipo Documento' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRREstadoCivil>> ModificarEstadoCivil(string NombreEstadoCivil, int id)
        {
            this._logger.LogWarning($"EstadoCivilRepository/UpdateEstadoCivil(): Inizialize...");
            var sql = this._estadoCivilQuery.ModificarEstadoCivil(NombreEstadoCivil, id);
            var resultado = await this._dbMysqlServerContext.HHRREstadoCivil.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"EstadoCivilRepository/ModificarEstadoCivil SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"EstadoCivilRepository/ModificarEstadoCivil: Message => 'No puso modificar' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRREstadoCivil>> EliminarEstadoCivil(int id)
        {
            this._logger.LogWarning($"EstadoCivilRepository/EliminarEstadoCivil(): Inizialize...");
            var sql = this._estadoCivilQuery.EliminarEstadoCivil(id);
            var resultado = await this._dbMysqlServerContext.HHRREstadoCivil.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"EstadoCivilRepository/EliminarEstadoCivil SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"EstadoCivilRepository/EliminarEstadoCivil: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
    }
}