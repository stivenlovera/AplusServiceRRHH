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
    public class DepartamentoRepositorio
    {
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly ILogger<DepartamentoRepositorio> _logger;
        private readonly DepartamentoQuery _departamentoQuery;

        public DepartamentoRepositorio(
            DbMysqlServerContext DbMysqlServerContext,
            ILogger<DepartamentoRepositorio> logger,
            DepartamentoQuery departamentoQuery
        )
        {
            this._dbMysqlServerContext = DbMysqlServerContext;
            this._logger = logger;
            this._departamentoQuery = departamentoQuery;
        }
        public async Task<List<HHRRDepartamento>> ObtenerDepartamentos()
        {
            this._logger.LogWarning($"DepartamentoRepositorio/ObtenerDepartamentos(): Inizialize...");
            var sql = this._departamentoQuery.ObtenerDepartamento();
            var resultado = await this._dbMysqlServerContext.HHRRDepartamento.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"DepartamentoRepositorio/ObtenerDepartamentos SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"DepartamentoRepositorio/ObtenerDepartamentos: Message => 'Error al buscar departamentos' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRDepartamento>> ObtenerDepartamentoId(int id)
        {
            this._logger.LogWarning($"DepartamentoRepository/ObtenerDepartamentoId(): Inizialize...");
            var sql = this._departamentoQuery.ObtenerDepartamentoId(id);
            var resultado = await this._dbMysqlServerContext.HHRRDepartamento.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"DepartamentoRepository/ObtenerDepartamentoId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"DepartamentoRepository/ObtenerDepartamentoId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRDepartamento>> CrearDepartamentoId(string NombreDepartamento, int PaisId)
        {
            this._logger.LogWarning($"DepartamentoRepository/CrearDepartamentoId(): Inizialize...");
            var sql = this._departamentoQuery.GuardarDepartamento(NombreDepartamento, PaisId);
            var resultado = await this._dbMysqlServerContext.HHRRDepartamento.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"DepartamentoRepository/CrearDepartamentoId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"DepartamentoRepository/CrearDepartamentoId: Message => 'No existe pudo crear Tipo Documento' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRDepartamento>> ModificarDepartamento(string NombreDepartamento,int PaisId, int id)
        {
            this._logger.LogWarning($"DepartamentoRepository/UpdateDepartamento(): Inizialize...");
            var sql = this._departamentoQuery.ModificarDepartamento(NombreDepartamento,PaisId, id);
            var resultado = await this._dbMysqlServerContext.HHRRDepartamento.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"DepartamentoRepository/ModificarDepartamento SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"DepartamentoRepository/ModificarDepartamento: Message => 'No puso modificar' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRDepartamento>> EliminarDepartamento(int id)
        {
            this._logger.LogWarning($"DepartamentoRepository/EliminarDepartamento(): Inizialize...");
            var sql = this._departamentoQuery.EliminarDepartamento(id);
            var resultado = await this._dbMysqlServerContext.HHRRDepartamento.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"DepartamentoRepository/EliminarDepartamento SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"DepartamentoRepository/EliminarDepartamento: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
    }
}