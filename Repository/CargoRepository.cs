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
    public class CargoRepository
    {
        private readonly ILogger<CargoRepository> _logger;
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly CargoQuery _cargoQuery;

        public CargoRepository(
            ILogger<CargoRepository> logger,
            DbMysqlServerContext dbMysqlServerContext,
            CargoQuery cargoQuery
        )
        {
            this._logger = logger;
            this._dbMysqlServerContext = dbMysqlServerContext;
            this._cargoQuery = cargoQuery;
        }
        public async Task<List<HHRRCargo>> ObtenerCargo()
        {
            this._logger.LogWarning($"CargoRepository/ObtenerCargo(): Inizialize...");
            var sql = this._cargoQuery.ObtenerCargo();
            var resultado = await this._dbMysqlServerContext.HHRRCargo.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"CargoRepository/ObtenerCargo SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"CargoRepository/ObtenerCargo: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRCargo>> ObtenerCargoId(int id)
        {
            this._logger.LogWarning($"CargoRepository/ObtenerCargoId(): Inizialize...");
            var sql = this._cargoQuery.ObtenerCargoId(id);
            var resultado = await this._dbMysqlServerContext.HHRRCargo.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"CargoRepository/ObtenerCargoId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"CargoRepository/ObtenerCargoId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRCargo>> CrearCargoId(string NombreCargo)
        {
            this._logger.LogWarning($"CargoRepository/CrearCargoId(): Inizialize...");
            var sql = this._cargoQuery.GuardarCargo(NombreCargo);
            var resultado = await this._dbMysqlServerContext.HHRRCargo.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"CargoRepository/CrearCargoId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"CargoRepository/CrearCargoId: Message => 'No existe pudo crear Tipo Documento' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRCargo>> ModificarCargo(string NombreCargo, int id)
        {
            this._logger.LogWarning($"CargoRepository/UpdateCargo(): Inizialize...");
            var sql = this._cargoQuery.ModificarCargo(NombreCargo, id);
            var resultado = await this._dbMysqlServerContext.HHRRCargo.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"CargoRepository/ModificarCargo SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"CargoRepository/ModificarCargo: Message => 'No puso modificar' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRCargo>> EliminarCargo(int id)
        {
            this._logger.LogWarning($"CargoRepository/EliminarCargo(): Inizialize...");
            var sql = this._cargoQuery.EliminarCargo(id);
            var resultado = await this._dbMysqlServerContext.HHRRCargo.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"CargoRepository/EliminarCargo SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"CargoRepository/EliminarCargo: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
    }
}