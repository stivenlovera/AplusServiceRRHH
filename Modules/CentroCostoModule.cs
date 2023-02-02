using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class CentroCostoModule
    {
        private readonly ILogger<CentroCostoModule> _logger;
        private readonly CentroCostoRepository _CentroCostoRepository;

        public CentroCostoModule(
            ILogger<CentroCostoModule> logger,
            CentroCostoRepository CentroCostoRepository
        )
        {
            this._logger = logger;
            this._CentroCostoRepository = CentroCostoRepository;
        }
        public async Task<List<HHRRCentroCosto>> ObtenerCentroCosto()
        {
            return await this._CentroCostoRepository.ObtenerCentroCostos();
        }
        public async Task<List<HHRRCentroCosto>> ObtenerCentroCostoId(int id)
        {
            return await this._CentroCostoRepository.ObtenerCentroCostoId(id);
        }
        public async Task<List<HHRRCentroCosto>> CrearCentroCosto(string NombreCentroCosto)
        {
            return await this._CentroCostoRepository.CrearCentroCostoId(NombreCentroCosto);
        }
        public async Task<List<HHRRCentroCosto>> ModificarCentroCostoId(string NombreCentroCosto, int id)
        {
            return await this._CentroCostoRepository.ModificarCentroCosto(NombreCentroCosto, id);
        }
        public async Task<List<HHRRCentroCosto>> EliminarCentroCostoId(int id)
        {
            return await this._CentroCostoRepository.EliminarCentroCosto(id);
        }
    }
}