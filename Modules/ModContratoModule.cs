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
        public async Task<HHRRModContrato> ObtenerModContratoId(int id)
        {
            return await this._ModoContratoRepository.ObtenerModoContratoId(id);
        }
        public async Task<bool> CrearModContrato(string NombreModContrato, int dias)
        {
            return await this._ModoContratoRepository.CrearModoContrato(NombreModContrato,dias);
        }
        public async Task<bool> ModificarModContrato(string NombreModContrato, int dias, int id)
        {
            return await this._ModoContratoRepository.ModificarModoContrato(NombreModContrato,dias, id);
        }
        public async Task<bool> EliminarModContrato(int id)
        {
            return await this._ModoContratoRepository.EliminarModoContrato(id);
        }
    }
}