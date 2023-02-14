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
                this._logger.LogError($"ModoContratoRepositorio/ObtenerModoContratos: Message => 'No se pudo obtener modalidades de contratos' CONSULT => {sql}");
                throw new Exception("No se pudo obtener modalidades de contratos");
            }
        }
        public async Task<HHRRModContrato> ObtenerModoContratoId(int id)
        {
            this._logger.LogWarning($"ModoContratoRepository/ObtenerModoContratoId({id}): Inizialize...");
            var sql = this._modContratoQuery.ObtenerModContratoId(id);
            var data = await this._dbMysqlServerContext.HHRRModContrato.FromSqlRaw(sql).ToListAsync();
            var resultado = data.FirstOrDefault();
            if (resultado != null)
            {
                this._logger.LogWarning($"ModoContratoRepository/ObtenerModoContratoId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"ModoContratoRepository/ObtenerModoContratoId: Message => 'No se pudo obtener modalidad de contrato' CONSULT => {sql}");
                throw new Exception("No se pudo obtener modalidad de contrato");
            }
        }
        public async Task<bool> CrearModoContrato(string NombreModoContrato, int dias)
        {
            this._logger.LogWarning($"ModoContratoRepository/CrearModoContratoId({NombreModoContrato},{dias}): Inizialize...");
            var sql = this._modContratoQuery.GuardarModContrato(NombreModoContrato, dias);
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado == 1)
            {
                this._logger.LogWarning($"ModoContratoRepository/CrearModoContratoId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"ModoContratoRepository/CrearModoContratoId: Message => 'No se puo obtener modalidad de contrato' CONSULT => {sql}");
                throw new Exception("No modalidad de contrato");
            }
        }
        public async Task<bool> ModificarModoContrato(string NombreModoContrato, int dias, int id)
        {
            this._logger.LogWarning($"ModoContratoRepository/UpdateModoContrato({NombreModoContrato},{id}): Inizialize...");
            var sql = this._modContratoQuery.ModificarModContrato(NombreModoContrato, dias, id);
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado == 1)
            {
                this._logger.LogWarning($"ModoContratoRepository/ModificarModoContrato SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"ModoContratoRepository/ModificarModoContrato: Message => 'No puso modificar' CONSULT => {sql}");
                throw new Exception("No se puso modificar");
            }
        }
        public async Task<bool> EliminarModoContrato(int id)
        {
            this._logger.LogWarning($"ModoContratoRepository/EliminarModoContrato({id}): Inizialize...");
            var sql = this._modContratoQuery.EliminarModContrato(id);
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado == 1)
            {
                this._logger.LogWarning($"ModoContratoRepository/EliminarModoContrato SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"ModoContratoRepository/EliminarModoContrato: Message => 'No se pudo eliminar' CONSULT => {sql}");
                throw new Exception("No se puso eliminar");
            }
        }
    }
}