using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class ModContratoModule
    {
         private readonly ILogger<ModContratoModule> _logger;
        private readonly ModoContratoRepository _ModoContratoRepository;

        public ModContratoModule(
            ILogger<ModContratoModule> logger,
            ModoContratoRepository ModoContratoRepository
        )
        {
            this._logger = logger;
            this._ModoContratoRepository = ModoContratoRepository;
        }
        public async Task<List<HHRRModContrato>> ObtenerModContrato()
        {
            return await this._ModoContratoRepository.ObtenerModoContratos();
        }
        public async Task<List<HHRRModContrato>> ObtenerModContratoId(int id)
        {
            return await this._ModoContratoRepository.ObtenerModoContratoId(id);
        }
        public async Task<List<HHRRModContrato>> CrearModContrato(string NombreModContrato)
        {
            return await this._ModoContratoRepository.CrearModoContrato(NombreModContrato);
        }
        public async Task<List<HHRRModContrato>> ModificarModContratoId(string NombreModContrato, int id)
        {
            return await this._ModoContratoRepository.ModificarModoContrato(NombreModContrato, id);
        }
        public async Task<List<HHRRModContrato>> EliminarModContratoId(int id)
        {
            return await this._ModoContratoRepository.EliminarModoContrato(id);
        }
    }
}