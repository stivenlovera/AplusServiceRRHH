using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Entities.DBAplusEmpresas.Asistencia;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class AsistenciaModule
    {
        private readonly ILogger<AsistenciaModule> _logger;
        private readonly AsistenciaRepository _asistenciaRepository;

        public AsistenciaModule(
            ILogger<AsistenciaModule> logger,
            AsistenciaRepository asistenciaRepository
        )
        {
            this._logger = logger;
            this._asistenciaRepository = asistenciaRepository;
        }
        public async Task<List<object>> DataTableAsistencia()
        {
            var asistencias = await this._asistenciaRepository.DataTableAsistencia();
            var resultados = new List<object>();
            foreach (var asistencia in asistencias)
            {
                resultados.Add(new
                {
                    id=asistencia.id,
                    fechaRegistro=asistencia.fechaRegistro.ToString("dd/MM/yyyy"),
                    nombreCompleto=$"{asistencia.Nombre1} {asistencia.Nombre2} {asistencia.Nombre3} {asistencia.ApellidoPaterno} {asistencia.ApellidoMaterno} {asistencia.ApellidoCasado}",
                    codigoColaborador=asistencia.CodigoColaborador,
                    horaEntrada=asistencia.horaEntrada,
                    horaSalida=asistencia.horaSalida,
                    nota=asistencia.nota,
                    cargo=asistencia.NombreCargo
                });
            }

            return resultados;
        }
        public async Task<HHRRAsistencia> ObtenerAsistenciaId(int id)
        {
            return await this._asistenciaRepository.ObtenerAsisteciaRepositoryId(id);
        }
        public async Task<bool> CrearAsistencia(
            DateTime fechaRegistro,
            DateTime? fechaEntrada,
            DateTime? fechaSalida,
            DateTime? horaEntrada,
            DateTime? horaSalida,
            string nota,
            int HHRRColaboradorId
        )
        {
            return await this._asistenciaRepository.CrearAsisteciaRepositoryId(
                fechaRegistro,
                fechaEntrada,
                fechaSalida,
                horaEntrada,
                horaSalida,
                nota,
                HHRRColaboradorId
            );
        }
        public async Task<bool> ModificarAsistenciaId(
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
            return await this._asistenciaRepository.ModificarAsisteciaRepository(
                id,
                fechaRegistro,
                fechaEntrada,
                fechaSalida,
                horaEntrada,
                horaSalida,
                nota,
                HHRRColaboradorId
            );
        }
        public async Task<bool> EliminarAsistenciaId(int id)
        {
            return await this._asistenciaRepository.EliminarAsisteciaRepository(id);
        }
    }
}