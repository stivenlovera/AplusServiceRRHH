using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class OficinaModule
    {
        private readonly ILogger<OficinaModule> _logger;
        private readonly OficinaRepository _OficinaRepository;

        public OficinaModule(
            ILogger<OficinaModule> logger,
            OficinaRepository OficinaRepository
        )
        {
            this._logger = logger;
            this._OficinaRepository = OficinaRepository;
        }
        public async Task<List<HHRROficina>> ObtenerOficina()
        {
            return await this._OficinaRepository.ObtenerOficina();
        }
        public async Task<List<HHRROficina>> ObtenerOficinaId(int id)
        {
            return await this._OficinaRepository.ObtenerOficinaId(id);
        }
        public async Task<List<HHRROficina>> CrearOficina(string NombreOficina, int SucursalId)
        {
            return await this._OficinaRepository.CrearOficina(NombreOficina, SucursalId);
        }
        public async Task<List<HHRROficina>> ModificarOficinaId(string NombreOficina, int SucursalId, int id)
        {
            return await this._OficinaRepository.ModificarOficina(NombreOficina, SucursalId, id);
        }
        public async Task<List<HHRROficina>> EliminarOficinaId(int id)
        {
            return await this._OficinaRepository.EliminarOficina(id);
        }
    }
}