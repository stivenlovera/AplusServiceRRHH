using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class TipoCuentaModule
    {
        private readonly ILogger<TipoCuentaModule> _logger;
        private readonly TipoCuentaRepository _TipoCuentaRepository;

        public TipoCuentaModule(
            ILogger<TipoCuentaModule> logger,
            TipoCuentaRepository TipoCuentaRepository
        )
        {
            this._logger = logger;
            this._TipoCuentaRepository = TipoCuentaRepository;
        }
        public async Task<List<HHRRTipoCuenta>> ObtenerTipoCuenta()
        {
            return await this._TipoCuentaRepository.ObtenerTipoCuentas();
        }
        public async Task<List<HHRRTipoCuenta>> ObtenerTipoCuentaId(int id)
        {
            return await this._TipoCuentaRepository.ObtenerTipoCuentaId(id);
        }
        public async Task<List<HHRRTipoCuenta>> CrearTipoCuenta(string NombreTipoCuenta)
        {
            return await this._TipoCuentaRepository.CrearTipoCuentaId(NombreTipoCuenta);
        }
        public async Task<List<HHRRTipoCuenta>> ModificarTipoCuentaId(string NombreTipoCuenta, int id)
        {
            return await this._TipoCuentaRepository.ModificarTipoCuenta(NombreTipoCuenta, id);
        }
        public async Task<List<HHRRTipoCuenta>> EliminarTipoCuentaId(int id)
        {
            return await this._TipoCuentaRepository.EliminarTipoCuenta(id);
        }
    }
}