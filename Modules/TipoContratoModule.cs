using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class TipoContratoModule
    {
        private readonly ILogger<TipoContratoModule> _logger;
        private readonly TipoContratoRepository _TipoContratoRepository;

        public TipoContratoModule(
            ILogger<TipoContratoModule> logger,
            TipoContratoRepository TipoContratoRepository
        )
        {
            this._logger = logger;
            this._TipoContratoRepository = TipoContratoRepository;
        }
        public async Task<List<HHRRTipoContrato>> ObtenerTipoContrato()
        {
            return await this._TipoContratoRepository.ObtenerTipoContratos();
        }
        public async Task<List<HHRRTipoContrato>> ObtenerTipoContratoId(int id)
        {
            return await this._TipoContratoRepository.ObtenerTipoContratoId(id);
        }
        public async Task<List<HHRRTipoContrato>> CrearTipoContrato(string NombreTipoContrato)
        {
            return await this._TipoContratoRepository.CrearTipoContratoId(NombreTipoContrato);
        }
        public async Task<List<HHRRTipoContrato>> ModificarTipoContratoId(string NombreTipoContrato, int id)
        {
            return await this._TipoContratoRepository.ModificarTipoContrato(NombreTipoContrato, id);
        }
        public async Task<List<HHRRTipoContrato>> EliminarTipoContratoId(int id)
        {
            return await this._TipoContratoRepository.EliminarTipoContrato(id);
        }
    }
}