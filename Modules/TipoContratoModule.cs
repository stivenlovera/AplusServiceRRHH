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
        public async Task<HHRRTipoContrato> ObtenerTipoContratoId(int id)
        {
            return await this._TipoContratoRepository.ObtenerTipoContratoId(id);
        }
        public async Task<bool> CrearTipoContrato(string NombreTipoContrato)
        {
            return await this._TipoContratoRepository.CrearTipoContrato(NombreTipoContrato);
        }
        public async Task<bool> ModificarTipoContratoId(string NombreTipoContrato, int id)
        {
            return await this._TipoContratoRepository.ModificarTipoContrato(NombreTipoContrato, id);
        }
        public async Task<bool> EliminarTipoContratoId(int id)
        {
            return await this._TipoContratoRepository.EliminarTipoContrato(id);
        }
    }
}