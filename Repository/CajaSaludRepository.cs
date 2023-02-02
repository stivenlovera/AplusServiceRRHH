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
    public class CajaSaludRepository
    {
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly ILogger<CajaSaludRepository> _logger;
        private readonly CajaSaludQuery _cajaSaludQuery;

        public CajaSaludRepository(
            DbMysqlServerContext DbMysqlServerContext,
            ILogger<CajaSaludRepository> logger,
            CajaSaludQuery cajaSaludQuery
        )
        {
            this._dbMysqlServerContext = DbMysqlServerContext;
            this._logger = logger;
            this._cajaSaludQuery = cajaSaludQuery;
        }
        public async Task<List<HHRRCajaSalud>> ObtenerCajaSalud()
        {
            this._logger.LogWarning($"CajaSaludRepositorio/ObtenerCajaSaluds(): Inizialize...");
            var sql = this._cajaSaludQuery.ObtenerCajaSalud();
            var resultado = await this._dbMysqlServerContext.HHRRCajaSalud.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"HHRRCajaSaludRepositorio/ObtenerCajaSaluds SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"CajaSaludRepositorio/ObtenerCajaSaluds: Message => 'Error al buscar CajaSaluds' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRCajaSalud>> ObtenerCajaSaludId(int id)
        {
            this._logger.LogWarning($"CajaSaludRepository/ObtenerCajaSaludId(): Inizialize...");
            var sql = this._cajaSaludQuery.ObtenerCajaSaludId(id);
            var resultado = await this._dbMysqlServerContext.HHRRCajaSalud.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"CajaSaludRepository/ObtenerCajaSaludId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"CajaSaludRepository/ObtenerCajaSaludId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRCajaSalud>> CrearCajaSaludId(string NombreCajaSalud)
        {
            this._logger.LogWarning($"CajaSaludRepository/CrearCajaSaludId(): Inizialize...");
            var sql = this._cajaSaludQuery.GuardarCajaSalud(NombreCajaSalud);
            var resultado = await this._dbMysqlServerContext.HHRRCajaSalud.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"CajaSaludRepository/CrearCajaSaludId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"CajaSaludRepository/CrearCajaSaludId: Message => 'No existe pudo crear Tipo Documento' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRCajaSalud>> ModificarCajaSalud(string NombreCajaSalud, int id)
        {
            this._logger.LogWarning($"CajaSaludRepository/UpdateCajaSalud(): Inizialize...");
            var sql = this._cajaSaludQuery.ModificarCajaSalud(NombreCajaSalud, id);
            var resultado = await this._dbMysqlServerContext.HHRRCajaSalud.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"CajaSaludRepository/ModificarCajaSalud SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"CajaSaludRepository/ModificarCajaSalud: Message => 'No puso modificar' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRCajaSalud>> EliminarCajaSalud(int id)
        {
            this._logger.LogWarning($"CajaSaludRepository/EliminarCajaSalud(): Inizialize...");
            var sql = this._cajaSaludQuery.EliminarCajaSalud(id);
            var resultado = await this._dbMysqlServerContext.HHRRCajaSalud.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"CajaSaludRepository/EliminarCajaSalud SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"CajaSaludRepository/EliminarCajaSalud: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
    }
}