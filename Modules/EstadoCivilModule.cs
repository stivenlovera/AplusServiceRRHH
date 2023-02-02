using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class EstadoCivilModule
    {
         private readonly ILogger<EstadoCivilModule> _logger;
        private readonly EstadoCivilRepository _EstadoCivilRepository;

        public EstadoCivilModule(
            ILogger<EstadoCivilModule> logger,
            EstadoCivilRepository EstadoCivilRepository
        )
        {
            this._logger = logger;
            this._EstadoCivilRepository = EstadoCivilRepository;
        }
        public async Task<List<HHRREstadoCivil>> ObtenerEstadoCivil()
        {
            return await this._EstadoCivilRepository.ObtenerEstadoCivil();
        }
        public async Task<List<HHRREstadoCivil>> ObtenerEstadoCivilId(int id)
        {
            return await this._EstadoCivilRepository.ObtenerEstadoCivilId(id);
        }
        public async Task<List<HHRREstadoCivil>> CrearEstadoCivil(string NombreEstadoCivil)
        {
            return await this._EstadoCivilRepository.CrearEstadoCivilId(NombreEstadoCivil);
        }
        public async Task<List<HHRREstadoCivil>> ModificarEstadoCivilId(string NombreEstadoCivil, int id)
        {
            return await this._EstadoCivilRepository.ModificarEstadoCivil(NombreEstadoCivil, id);
        }
        public async Task<List<HHRREstadoCivil>> EliminarEstadoCivilId(int id)
        {
            return await this._EstadoCivilRepository.EliminarEstadoCivil(id);
        }
    }
}