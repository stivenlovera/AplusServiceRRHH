using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class ClasificacionLaboralModule
    {
        private readonly ILogger<ClasificacionLaboralModule> _logger;
        private readonly ClasificacionLaboralRepository _ClasificacionLaboralRepository;

        public ClasificacionLaboralModule(
            ILogger<ClasificacionLaboralModule> logger,
            ClasificacionLaboralRepository ClasificacionLaboralRepository
        )
        {
            this._logger = logger;
            this._ClasificacionLaboralRepository = ClasificacionLaboralRepository;
        }
        public async Task<List<HHRRClasificacionLaboral>> ObtenerClasificacionLaboral()
        {
            return await this._ClasificacionLaboralRepository.ObtenerClasificacionLaboral();
        }
        public async Task<List<HHRRClasificacionLaboral>> ObtenerClasificacionLaboralId(int id)
        {
            return await this._ClasificacionLaboralRepository.ObtenerClasificacionLaboralId(id);
        }
        public async Task<List<HHRRClasificacionLaboral>> CrearClasificacionLaboral(string NombreClasificacionLaboral)
        {
            return await this._ClasificacionLaboralRepository.CrearClasificacionLaboralId(NombreClasificacionLaboral);
        }
        public async Task<List<HHRRClasificacionLaboral>> ModificarClasificacionLaboralId(string NombreClasificacionLaboral, int id)
        {
            return await this._ClasificacionLaboralRepository.ModificarClasificacionLaboralId(NombreClasificacionLaboral, id);
        }
        public async Task<List<HHRRClasificacionLaboral>> EliminarClasificacionLaboralId(int id)
        {
            return await this._ClasificacionLaboralRepository.EliminarClasificacionLaboral(id);
        }
    }
}