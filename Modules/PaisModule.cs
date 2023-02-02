using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class PaisModule
    {
         private readonly ILogger<PaisModule> _logger;
        private readonly PaisRepository _PaisRepository;

        public PaisModule(
            ILogger<PaisModule> logger,
            PaisRepository PaisRepository
        )
        {
            this._logger = logger;
            this._PaisRepository = PaisRepository;
        }
        public async Task<List<HHRRPais>> ObtenerPais()
        {
            return await this._PaisRepository.ObtenerPais();
        }
        public async Task<List<HHRRPais>> ObtenerPaisId(int id)
        {
            return await this._PaisRepository.ObtenerPaisId(id);
        }
        public async Task<List<HHRRPais>> CrearPais(string NombrePais)
        {
            return await this._PaisRepository.CrearPaisId(NombrePais);
        }
        public async Task<List<HHRRPais>> ModificarPaisId(string NombrePais, int id)
        {
            return await this._PaisRepository.ModificarPais(NombrePais, id);
        }
        public async Task<List<HHRRPais>> EliminarPaisId(int id)
        {
            return await this._PaisRepository.EliminarPais(id);
        }
    }
}