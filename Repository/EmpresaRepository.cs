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
    public class EmpresaRepository
    {
        private readonly ILogger<EmpresaRepository> _logger;
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly EmpresaQuery _empresaQuery;

        public EmpresaRepository(
            ILogger<EmpresaRepository> logger,
            DbMysqlServerContext dbMysqlServerContext,
            EmpresaQuery empresaQuery
        )
        {
            this._logger = logger;
            this._dbMysqlServerContext = dbMysqlServerContext;
            this._empresaQuery = empresaQuery;
        }
        public async Task<List<Empresa>> ObtenerEmpresasRepository()
        {
            this._logger.LogWarning($"EmpresaRepository/ObtenerEmpresasRepository(): Inizialize...");
            var sql = this._empresaQuery.ObtenerEmpresas();
            var resultado = await this._dbMysqlServerContext.Empresa.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"EmpresaRepository/ObtenerEmpresasRepository SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"EmpresaRepository/ObtenerEmpresasRepository: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No se pudo obtener empresas");
            }
        }
        public async Task<Empresa> ObtenerObtenerEmpresaIdRepository(int id)
        {
            this._logger.LogWarning($"EmpresaRepository/ObtenerCargoId(): Inizialize...");
            var sql = this._empresaQuery.ObtenerEmpresa(id);
            var data = await this._dbMysqlServerContext.Empresa.FromSqlRaw(sql).ToListAsync();
            var resultado = data.FirstOrDefault();
            if (resultado != null)
            {
                this._logger.LogWarning($"EmpresaRepository/ObtenerCargoId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"EmpresaRepository/ObtenerCargoId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No se pudo obtener empresa");
            }
        }
        /* public async Task<bool> CrearCargoId(string NombreCargo)
        {
            this._logger.LogWarning($"CargoRepository/CrearCargoId(): Inizialize...");
            var sql = this._cargoQuery.GuardarCargo(NombreCargo);
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado == 1)
            {
                this._logger.LogWarning($"CargoRepository/CrearCargoId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"CargoRepository/CrearCargoId: Message => 'No existe pudo crear Cargo' CONSULT => {sql}");
                throw new Exception("No se pudo crear cargo");
            }
        } */
        public async Task<bool> ModificarEmpresaRepository(
            int id,
            string Nombre,
            string Descripcion,
            string Dirrecion,
            string Representante,
            DateTime fechaIngreso
            )
        {
            this._logger.LogWarning($"EmpresaRepository/ModificarEmpresaRepository(): Inizialize...");
            var sql = this._empresaQuery.ModificarEmpresa(
                id,
                Nombre,
                Descripcion,
                Dirrecion,
                Representante,
                fechaIngreso
            );
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado == 1)
            {
                this._logger.LogWarning($"EmpresaRepository/ModificarEmpresaRepository SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"EmpresaRepository/ModificarEmpresaRepository: Message => 'No puso modificar cargo' CONSULT => {sql}");
                throw new Exception("No se pudo modificar");
            }
        }
        /*  public async Task<bool> EliminarCargo(int id)
         {
             this._logger.LogWarning($"CargoRepository/EliminarCargo(): Inizialize...");
             var sql = this._cargoQuery.EliminarCargo(id);
             var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
             if (resultado == 1)
             {
                 this._logger.LogWarning($"CargoRepository/EliminarCargo SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                 return true;
             }
             else
             {
                 this._logger.LogError($"CargoRepository/EliminarCargo: Message => 'No se pudo eliminar' CONSULT => {sql}");
                 throw new Exception("No se pudo eliminar cargo");
             }
         } */
    }
}