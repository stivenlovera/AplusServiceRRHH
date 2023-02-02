using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class BancoModule
    {
         private readonly ILogger<BancoModule> _logger;
        private readonly BancoRepository _BancoRepository;

        public BancoModule(
            ILogger<BancoModule> logger,
            BancoRepository BancoRepository
        )
        {
            this._logger = logger;
            this._BancoRepository = BancoRepository;
        }
        public async Task<List<HHRRBanco>> ObtenerBanco()
        {
            return await this._BancoRepository.ObtenerBancos();
        }
        public async Task<List<HHRRBanco>> ObtenerBancoId(int id)
        {
            return await this._BancoRepository.ObtenerBancoId(id);
        }
        public async Task<List<HHRRBanco>> CrearBanco(string NombreBanco)
        {
            return await this._BancoRepository.CrearBancoId(NombreBanco);
        }
        public async Task<List<HHRRBanco>> ModificarBancoId(string NombreBanco, int id)
        {
            return await this._BancoRepository.ModificarBanco(NombreBanco, id);
        }
        public async Task<List<HHRRBanco>> EliminarBancoId(int id)
        {
            return await this._BancoRepository.EliminarBanco(id);
        }
    }
}