using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class FormaPagoModule
    {
         private readonly ILogger<FormaPagoModule> _logger;
        private readonly FormaPagoRepository _FormaPagoRepository;

        public FormaPagoModule(
            ILogger<FormaPagoModule> logger,
            FormaPagoRepository FormaPagoRepository
        )
        {
            this._logger = logger;
            this._FormaPagoRepository = FormaPagoRepository;
        }
        public async Task<List<HHRRFormaPago>> ObtenerFormaPago()
        {
            return await this._FormaPagoRepository.ObtenerFormaPagos();
        }
        public async Task<List<HHRRFormaPago>> ObtenerFormaPagoId(int id)
        {
            return await this._FormaPagoRepository.ObtenerFormaPagoId(id);
        }
        public async Task<List<HHRRFormaPago>> CrearFormaPago(string NombreFormaPago)
        {
            return await this._FormaPagoRepository.CrearFormaPagoId(NombreFormaPago);
        }
        public async Task<List<HHRRFormaPago>> ModificarFormaPagoId(string NombreFormaPago, int id)
        {
            return await this._FormaPagoRepository.ModificarFormaPago(NombreFormaPago, id);
        }
        public async Task<List<HHRRFormaPago>> EliminarFormaPagoId(int id)
        {
            return await this._FormaPagoRepository.EliminarFormaPago(id);
        }
    }
}