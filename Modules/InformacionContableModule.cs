using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class InformacionContableModule
    {
         private readonly ILogger<InformacionContableModule> _logger;
        private readonly InformacionContableRepository _informacionContableRepository;

        public InformacionContableModule(
            ILogger<InformacionContableModule> logger,
            InformacionContableRepository informacionContableRepository
        )
        {
            this._logger = logger;
            this._informacionContableRepository = informacionContableRepository;
        }
        public async Task<List<HHRRInformacionContable>> ObtenerInformacionContable()
        {
            return await this._informacionContableRepository.ObtenerInformacionContables();
        }
        public async Task<List<HHRRInformacionContable>> ObtenerInformacionContableId(int id)
        {
            return await this._informacionContableRepository.ObtenerInformacionContableId(id);
        }
        public async Task<List<HHRRInformacionContable>> CrearInformacionContable(string NombreInformacionContable)
        {
            return await this._informacionContableRepository.CrearInformacionContableId(NombreInformacionContable);
        }
        public async Task<List<HHRRInformacionContable>> ModificarInformacionContableId(string NombreInformacionContable, int id)
        {
            return await this._informacionContableRepository.ModificarInformacionContable(NombreInformacionContable, id);
        }
        public async Task<List<HHRRInformacionContable>> EliminarInformacionContableId(int id)
        {
            return await this._informacionContableRepository.EliminarInformacionContable(id);
        }
    }
}