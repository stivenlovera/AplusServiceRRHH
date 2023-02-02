using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class CajaSaludModule
    {
         private readonly ILogger<CajaSaludModule> _logger;
        private readonly CajaSaludRepository _CajaSaludRepository;

        public CajaSaludModule(
            ILogger<CajaSaludModule> logger,
            CajaSaludRepository CajaSaludRepository
        )
        {
            this._logger = logger;
            this._CajaSaludRepository = CajaSaludRepository;
        }
        public async Task<List<HHRRCajaSalud>> ObtenerCajaSalud()
        {
            return await this._CajaSaludRepository.ObtenerCajaSalud();
        }
        public async Task<List<HHRRCajaSalud>> ObtenerCajaSaludId(int id)
        {
            return await this._CajaSaludRepository.ObtenerCajaSaludId(id);
        }
        public async Task<List<HHRRCajaSalud>> CrearCajaSalud(string NombreCajaSalud)
        {
            return await this._CajaSaludRepository.CrearCajaSaludId(NombreCajaSalud);
        }
        public async Task<List<HHRRCajaSalud>> ModificarCajaSaludId(string NombreCajaSalud, int id)
        {
            return await this._CajaSaludRepository.ModificarCajaSalud(NombreCajaSalud, id);
        }
        public async Task<List<HHRRCajaSalud>> EliminarCajaSaludId(int id)
        {
            return await this._CajaSaludRepository.EliminarCajaSalud(id);
        }
    }
}