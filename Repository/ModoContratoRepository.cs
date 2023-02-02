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
    public class ModoContratoRepository
    {
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly ILogger<ModoContratoRepository> _logger;
        private readonly ModContratoQuery _modContratoQuery;

        public ModoContratoRepository(
            DbMysqlServerContext DbMysqlServerContext,
            ILogger<ModoContratoRepository> logger,
            ModContratoQuery modContratoQuery
        )
        {
            this._dbMysqlServerContext = DbMysqlServerContext;
            this._logger = logger;
            this._modContratoQuery = modContratoQuery;
        }
        public async Task<List<HHRRModContrato>> ObtenerModoContratos()
        {
            this._logger.LogWarning($"ModoContratoRepositorio/ObtenerModoContratos(): Inizialize...");
            var sql = this._modContratoQuery.ObtenerModContrato();
            var resultado = await this._dbMysqlServerContext.HHRRModContrato.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"ModoContratoRepositorio/ObtenerModoContratos SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"ModoContratoRepositorio/ObtenerModoContratos: Message => 'Error al buscar ModoContratos' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRModContrato>> ObtenerModoContratoId(int id)
        {
            this._logger.LogWarning($"ModoContratoRepository/ObtenerModoContratoId(): Inizialize...");
            var sql = this._modContratoQuery.ObtenerModContratoId(id);
            var resultado = await this._dbMysqlServerContext.HHRRModContrato.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"ModoContratoRepository/ObtenerModoContratoId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"ModoContratoRepository/ObtenerModoContratoId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRModContrato>> CrearModoContrato(string NombreModoContrato)
        {
            this._logger.LogWarning($"ModoContratoRepository/CrearModoContratoId(): Inizialize...");
            var sql = this._modContratoQuery.GuardarModContrato(NombreModoContrato);
            var resultado = await this._dbMysqlServerContext.HHRRModContrato.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"ModoContratoRepository/CrearModoContratoId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"ModoContratoRepository/CrearModoContratoId: Message => 'No existe pudo crear Tipo Documento' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRModContrato>> ModificarModoContrato(string NombreModoContrato, int id)
        {
            this._logger.LogWarning($"ModoContratoRepository/UpdateModoContrato(): Inizialize...");
            var sql = this._modContratoQuery.ModificarModContrato(NombreModoContrato, id);
            var resultado = await this._dbMysqlServerContext.HHRRModContrato.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"ModoContratoRepository/ModificarModoContrato SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"ModoContratoRepository/ModificarModoContrato: Message => 'No puso modificar' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRModContrato>> EliminarModoContrato(int id)
        {
            this._logger.LogWarning($"ModoContratoRepository/EliminarModoContrato(): Inizialize...");
            var sql = this._modContratoQuery.EliminarModContrato(id);
            var resultado = await this._dbMysqlServerContext.HHRRModContrato.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"ModoContratoRepository/EliminarModoContrato SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"ModoContratoRepository/EliminarModoContrato: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
    }
}