using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class AdministracionPensionesModule
    {
        private readonly ILogger<AdministracionPensionesModule> _logger;
        private readonly AdministracionPesionRepository _administracionPesionRepository;

        public AdministracionPensionesModule(
            ILogger<AdministracionPensionesModule> logger,
            AdministracionPesionRepository administracionPesionRepository
        )
        {
            this._logger = logger;
            this._administracionPesionRepository = administracionPesionRepository;
        }
        public async Task<List<HHRRAdministracionPesion>> ObtenerAdministracionPesion()
        {
            return await this._administracionPesionRepository.ObtenerAdministracionPesion();
        }
        public async Task<List<HHRRAdministracionPesion>> ObtenerAdministracionPesionId(int id)
        {
            return await this._administracionPesionRepository.ObtenerAdministracionPesionId(id);
        }
        public async Task<List<HHRRAdministracionPesion>> CrearAdministracionPesion(string NombreAdministracionPesion)
        {
            return await this._administracionPesionRepository.CrearAdministracionPesionId(NombreAdministracionPesion);
        }
        public async Task<List<HHRRAdministracionPesion>> ModificarAdministracionPesionId(string NombreAdministracionPesion, int id)
        {
            return await this._administracionPesionRepository.ModificarAdministracionPesion(NombreAdministracionPesion, id);
        }
        public async Task<List<HHRRAdministracionPesion>> EliminarAdministracionPesionId(int id)
        {
            return await this._administracionPesionRepository.EliminarAdministracionPesion(id);
        }
    }
}