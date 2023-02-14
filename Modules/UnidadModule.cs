using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class UnidadModule
    {
        private readonly ILogger<UnidadModule> _logger;
        private readonly UnidadRepository _unidadRepository;

        public UnidadModule(
            ILogger<UnidadModule> logger,
            UnidadRepository unidadRepository
        )
        {
            this._logger = logger;
            this._unidadRepository = unidadRepository;
        }
        public async Task<List<HHRRUnidad>> ObtenerUnidad()
        {
            return await this._unidadRepository.ObtenerUnidad();
        }
        public async Task<HHRRUnidad> ObtenerUnidadId(int id)
        {
            return await this._unidadRepository.ObtenerUnidadId(id);
        }
        public async Task<bool> CrearUnidad(string NombreUnidad)
        {
            return await this._unidadRepository.CrearUnidadId(NombreUnidad);
        }
        public async Task<bool> ModificarUnidadId(string NombreUnidad, int id)
        {
            return await this._unidadRepository.ModificarUnidad(NombreUnidad, id);
        }
        public async Task<bool> EliminarUnidadId(int id)
        {
            return await this._unidadRepository.EliminarUnidad(id);
        }
    }
}