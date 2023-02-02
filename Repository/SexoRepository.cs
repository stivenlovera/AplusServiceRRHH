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
    public class SexoRepository
    {
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly ILogger<SexoRepository> _logger;
        private readonly SexoQuery _sexoQuery;

        public SexoRepository(
            DbMysqlServerContext DbMysqlServerContext,
            ILogger<SexoRepository> logger,
            SexoQuery sexoQuery
        )
        {
            this._dbMysqlServerContext = DbMysqlServerContext;
            this._logger = logger;
            this._sexoQuery = sexoQuery;
        }
        public async Task<List<HHRRSexo>> ObtenerSexo()
        {
            this._logger.LogWarning($"SexoRepositorio/ObtenerSexo(): Inizialize...");
            var sql = this._sexoQuery.ObtenerSexo();
            var resultado = await this._dbMysqlServerContext.HHRRSexo.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"SexoRepositorio/ObtenerSexo SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"SexoRepositorio/ObtenerSexo: Message => 'Error al buscar Sexo' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRSexo>> ObtenerSexoId(int id)
        {
            this._logger.LogWarning($"SexoRepository/ObtenerSexoId(): Inizialize...");
            var sql = this._sexoQuery.ObtenerSexoId(id);
            var resultado = await this._dbMysqlServerContext.HHRRSexo.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"SexoRepository/ObtenerSexoId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"SexoRepository/ObtenerSexoId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRSexo>> CrearSexoId(string NombreSexo)
        {
            this._logger.LogWarning($"SexoRepository/CrearSexoId(): Inizialize...");
            var sql = this._sexoQuery.GuardarSexo(NombreSexo);
            var resultado = await this._dbMysqlServerContext.HHRRSexo.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"SexoRepository/CrearSexoId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"SexoRepository/CrearSexoId: Message => 'No existe pudo crear Tipo Documento' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRSexo>> ModificarSexo(string NombreSexo, int id)
        {
            this._logger.LogWarning($"SexoRepository/UpdateSexo(): Inizialize...");
            var sql = this._sexoQuery.ModificarSexo(NombreSexo, id);
            var resultado = await this._dbMysqlServerContext.HHRRSexo.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"SexoRepository/ModificarSexo SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"SexoRepository/ModificarSexo: Message => 'No puso modificar' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRSexo>> EliminarSexo(int id)
        {
            this._logger.LogWarning($"SexoRepository/EliminarSexo(): Inizialize...");
            var sql = this._sexoQuery.EliminarSexo(id);
            var resultado = await this._dbMysqlServerContext.HHRRSexo.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"SexoRepository/EliminarSexo SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"SexoRepository/EliminarSexo: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
    }
}