using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class TipoDocumentoModule
    {
        private readonly ILogger<TipoDocumentoModule> _logger;
        private readonly TipoDocumentoRepository _tipoDocumentoRepository;

        public TipoDocumentoModule(
            ILogger<TipoDocumentoModule> logger,
            TipoDocumentoRepository tipoDocumentoRepository
        )
        {
            this._logger = logger;
            this._tipoDocumentoRepository = tipoDocumentoRepository;
        }
        public async Task<List<HHRRTipoDocumento>> ObtenerTipoDocumento()
        {
            return await this._tipoDocumentoRepository.ObtenerTipoDocumento();
        }
        public async Task<List<HHRRTipoDocumento>> ObtenerTipoDocumentoId(int id)
        {
            return await this._tipoDocumentoRepository.ObtenerTipoDocumentoId(id);
        }
        public async Task<List<HHRRTipoDocumento>> CrearTipoDocumento(string NombreTipoDocumento)
        {
            return await this._tipoDocumentoRepository.CrearTipoDocumentoId(NombreTipoDocumento);
        }
        public async Task<List<HHRRTipoDocumento>> ModificarTipoDocumentoId(string NombreTipoDocumento,int id)
        {
            return await this._tipoDocumentoRepository.ModificarTipoDocumento(NombreTipoDocumento,id);
        }
        public async Task<List<HHRRTipoDocumento>> EliminarTipoDocumentoId(int id)
        {
            return await this._tipoDocumentoRepository.EliminarTipoDocumento(id);
        }
    }

}