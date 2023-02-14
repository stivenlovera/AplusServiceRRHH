using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class CargoModule
    {
        private readonly ILogger<CargoModule> _logger;
        private readonly CargoRepository _cargoRepository;

        public CargoModule(
            ILogger<CargoModule> logger,
            CargoRepository cargoRepository
        )
        {
            this._logger = logger;
            this._cargoRepository = cargoRepository;
        }
        public async Task<List<HHRRCargo>> ObtenerCargo()
        {
            return await this._cargoRepository.ObtenerCargo();
        }
        public async Task<HHRRCargo> ObtenerCargoId(int id)
        {
            return await this._cargoRepository.ObtenerCargoId(id);
        }
        public async Task<bool> CrearCargo(string NombreCargo)
        {
            return await this._cargoRepository.CrearCargoId(NombreCargo);
        }
        public async Task<bool> ModificarCargoId(string NombreCargo, int id)
        {
            return await this._cargoRepository.ModificarCargo(NombreCargo, id);
        }
        public async Task<bool> EliminarCargoId(int id)
        {
            return await this._cargoRepository.EliminarCargo(id);
        }
    }
}