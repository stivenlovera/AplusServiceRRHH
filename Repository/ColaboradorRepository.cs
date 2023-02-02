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
    public class ColaboradorRepository
    {
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly ILogger<ColaboradorRepository> _logger;
        private readonly ColaboradorQuery _colaboradorQuery;

        public ColaboradorRepository(
            DbMysqlServerContext DbMysqlServerContext,
            ILogger<ColaboradorRepository> logger,
            ColaboradorQuery colaboradorQuery
        )
        {
            this._dbMysqlServerContext = DbMysqlServerContext;
            this._logger = logger;
            this._colaboradorQuery = colaboradorQuery;
        }
        public async Task<List<HHRRColaborador>> ObtenerColaborador()
        {
            this._logger.LogWarning($"ColaboradorRepository/ObtenerColaborador(): Inizialize...");
            var sql = this._colaboradorQuery.ObtenerColaborador();
            var resultado = await this._dbMysqlServerContext.HHRRColaborador.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"ColaboradorRepository/ObtenerColaborador SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"ColaboradorRepository/ObtenerColaborador: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRColaborador>> ObtenerColaboradorId(int id)
        {
            this._logger.LogWarning($"ColaboradorRepository/ObtenerColaboradorId(): Inizialize...");
            var sql = this._colaboradorQuery.ObtenerColaboradorId(id);
            var resultado = await this._dbMysqlServerContext.HHRRColaborador.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"ColaboradorRepository/ObtenerColaboradorId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"ColaboradorRepository/ObtenerColaboradorId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRColaborador>> CrearColaboradorId(string NombreColaborador)
        {
            this._logger.LogWarning($"ColaboradorRepository/CrearColaboradorId(): Inizialize...");
            var sql = this._colaboradorQuery.GuardarColaborador(NombreColaborador);
            var resultado = await this._dbMysqlServerContext.HHRRColaborador.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"ColaboradorRepository/CrearColaboradorId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"ColaboradorRepository/CrearColaboradorId: Message => 'No existe pudo crear Tipo Documento' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRColaborador>> ModificarColaborador(string NombreColaborador, int id)
        {
            this._logger.LogWarning($"ColaboradorRepository/UpdateColaborador(): Inizialize...");
            var sql = this._colaboradorQuery.ModificarColaborador(NombreColaborador, id);
            var resultado = await this._dbMysqlServerContext.HHRRColaborador.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"ColaboradorRepository/ModificarColaborador SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"ColaboradorRepository/ModificarColaborador: Message => 'No puso modificar' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRColaborador>> EliminarColaborador(int id)
        {
            this._logger.LogWarning($"ColaboradorRepository/EliminarColaborador(): Inizialize...");
            var sql = this._colaboradorQuery.EliminarColaborador(id);
            var resultado = await this._dbMysqlServerContext.HHRRColaborador.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"ColaboradorRepository/EliminarColaborador SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"ColaboradorRepository/EliminarColaborador: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<ColaboradorDataTable>> DatatableColaborador()
        {
            this._logger.LogWarning($"ColaboradorRepository/DatatableColaborador(): Inizialize...");
            var sql = this._colaboradorQuery.DatatableColaborador();
            var resultado = await this._dbMysqlServerContext.ColaboradorDataTable.FromSqlRaw(sql).ToListAsync();

            this._logger.LogWarning($"ColaboradorRepository/DatatableColaborador SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
            return resultado;
        }
    }
}