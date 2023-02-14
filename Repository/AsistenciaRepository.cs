using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Context;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Entities.DBAplusEmpresas.Asistencia;
using AplusServiceRRHH.Querys;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace AplusServiceRRHH.Repository
{
    public class AsistenciaRepository
    {
        public ILogger<AsistenciaRepository> _logger { get; }
        public DbMysqlServerContext _dbMysqlServerContext { get; }
        public AsistenciaQuery _asistenciaQuery { get; }

        public AsistenciaRepository(
            ILogger<AsistenciaRepository> logger,
            DbMysqlServerContext dbMysqlServerContext,
            AsistenciaQuery asistenciaQuery
        )
        {
            this._logger = logger;
            this._dbMysqlServerContext = dbMysqlServerContext;
            this._asistenciaQuery = asistenciaQuery;
        }
        public async Task<List<AsistenciaDataTable>> DataTableAsistencia()
        {
            this._logger.LogWarning($"AsistenciaRepository/DataTableAsistencia(): Inizialize...");
            var sql = this._asistenciaQuery.DataTable();
            var resultado = await this._dbMysqlServerContext.AsistenciaDataTable.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"AsistenciaRepository/DataTableAsistencia SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"AsistenciaRepository/DataTableAsistencia: Message => 'Eror al obtener asistencia' CONSULT => {sql}");
                throw new Exception("Eror al obtener asistencia");
            }
        }
        public async Task<HHRRAsistencia> ObtenerAsisteciaRepositoryId(int id)
        {
            this._logger.LogWarning($"AsistenciaRepository/ObtenerAsisteciaRepositoryId({id}): Inizialize...");
            var sql = this._asistenciaQuery.ObtenerAsistenciaId(id);
            var data = await this._dbMysqlServerContext.HHRRAsistencia.FromSqlRaw(sql).ToListAsync();
            var resultado = data.FirstOrDefault();
            if (resultado != null)
            {
                this._logger.LogWarning($"AsistenciaRepository/ObtenerAsisteciaRepositoryId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"AsistenciaRepository/ObtenerAsisteciaRepositoryId: Message => 'No se pudo obtener la asistencia' CONSULT => {sql}");
                throw new Exception("No se pudo obtener la asistencia");
            }
        }
        public async Task<bool> CrearAsisteciaRepositoryId(
            DateTime fechaRegistro,
            DateTime? fechaEntrada,
            DateTime? fechaSalida,
            DateTime? horaEntrada,
            DateTime? horaSalida,
            string nota,
            int HHRRColaboradorId
        )
        {
            this._logger.LogWarning($"AsistenciaRepository/CrearAsisteciaRepositoryId({fechaRegistro},{fechaEntrada},{fechaSalida},{horaEntrada},{horaSalida},{nota},{HHRRColaboradorId}): Inizialize...");
            var sql = this._asistenciaQuery.GuardarAsistencia(
                fechaRegistro,
                fechaEntrada,
                fechaSalida,
                horaEntrada,
                horaSalida,
                nota,
                HHRRColaboradorId
            );
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado == 1)
            {
                this._logger.LogWarning($"AsistenciaRepository/CrearAsisteciaRepositoryId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"AsistenciaRepository/CrearAsisteciaRepositoryId: Message => 'No existe registrar asistencia' CONSULT => {sql}");
                throw new Exception("No existe registrar asistencia");
            }
        }
        public async Task<bool> ModificarAsisteciaRepository(
            int id,
            DateTime fechaRegistro,
            DateTime? fechaEntrada,
            DateTime? fechaSalida,
            DateTime? horaEntrada,
            DateTime? horaSalida,
            string nota,
            int HHRRColaboradorId
            )
        {
            this._logger.LogWarning($"AsistenciaRepository/ModificarAsisteciaRepository({id},{fechaRegistro},{fechaEntrada},{fechaSalida},{horaEntrada},{horaSalida},{nota},{HHRRColaboradorId}): Inizialize...");
            var sql = this._asistenciaQuery.ModificarAsistencia(
                id,
                fechaRegistro,
                fechaEntrada,
                fechaSalida,
                horaEntrada,
                horaSalida,
                nota,
                HHRRColaboradorId
            );
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado == 1)
            {
                this._logger.LogWarning($"AsistenciaRepository/ModificarAsisteciaRepository SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"AsistenciaRepository/ModificarAsisteciaRepository: Message => 'No se pudo moficar asistencia' CONSULT => {sql}");
                throw new Exception("No se pudo moficar asistencia");
            }
        }
        public async Task<bool> EliminarAsisteciaRepository(int id)
        {
            this._logger.LogWarning($"AsistenciaRepository/EliminarAsisteciaRepository({id}): Inizialize...");
            var sql = this._asistenciaQuery.EliminarAsistencia(id);
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado == 1)
            {
                this._logger.LogWarning($"AsistenciaRepository/EliminarAsisteciaRepository SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"AsistenciaRepository/EliminarAsisteciaRepository: Message => 'No se pudo eliminar asistencia' CONSULT => {sql}");
                throw new Exception("No se pudo eliminar asistencia");
            }
        }
    }
}