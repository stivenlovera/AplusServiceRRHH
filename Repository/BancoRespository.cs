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
    public class BancoRepository
    {
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly ILogger<BancoRepository> _logger;
        private readonly BancosQuery _bancosQuery;

        public BancoRepository(
            DbMysqlServerContext DbMysqlServerContext,
            ILogger<BancoRepository> logger,
            BancosQuery bancosQuery
        )
        {
            this._dbMysqlServerContext = DbMysqlServerContext;
            this._logger = logger;
            this._bancosQuery = bancosQuery;
        }
        public async Task<List<HHRRBanco>> ObtenerBancos()
        {
            this._logger.LogWarning($"BancoRepositorio/ObtenerBancos(): Inizialize...");
            var sql = this._bancosQuery.ObtenerBanco();
            var resultado = await this._dbMysqlServerContext.HHRRBanco.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"BancoRepositorio/ObtenerBancos SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"BancoRepositorio/ObtenerBancos: Message => 'Error al buscar Bancos' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRBanco>> ObtenerBancoId(int id)
        {
            this._logger.LogWarning($"BancoRepository/ObtenerBancoId(): Inizialize...");
            var sql = this._bancosQuery.ObtenerBancoId(id);
            var resultado = await this._dbMysqlServerContext.HHRRBanco.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"BancoRepository/ObtenerBancoId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"BancoRepository/ObtenerBancoId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRBanco>> CrearBancoId(string NombreBanco)
        {
            this._logger.LogWarning($"BancoRepository/CrearBancoId(): Inizialize...");
            var sql = this._bancosQuery.GuardarBanco(NombreBanco);
            var resultado = await this._dbMysqlServerContext.HHRRBanco.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"BancoRepository/CrearBancoId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"BancoRepository/CrearBancoId: Message => 'No existe pudo crear Tipo Documento' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRBanco>> ModificarBanco(string NombreBanco, int id)
        {
            this._logger.LogWarning($"BancoRepository/UpdateBanco(): Inizialize...");
            var sql = this._bancosQuery.ModificarBanco(NombreBanco, id);
            var resultado = await this._dbMysqlServerContext.HHRRBanco.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"BancoRepository/ModificarBanco SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"BancoRepository/ModificarBanco: Message => 'No puso modificar' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRBanco>> EliminarBanco(int id)
        {
            this._logger.LogWarning($"BancoRepository/EliminarBanco(): Inizialize...");
            var sql = this._bancosQuery.EliminarBanco(id);
            var resultado = await this._dbMysqlServerContext.HHRRBanco.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"BancoRepository/EliminarBanco SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"BancoRepository/EliminarBanco: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
    }
}