using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class SexoModule
    {
         private readonly ILogger<SexoModule> _logger;
        private readonly SexoRepository _SexoRepository;

        public SexoModule(
            ILogger<SexoModule> logger,
            SexoRepository SexoRepository
        )
        {
            this._logger = logger;
            this._SexoRepository = SexoRepository;
        }
        public async Task<List<HHRRSexo>> ObtenerSexo()
        {
            return await this._SexoRepository.ObtenerSexo();
        }
        public async Task<List<HHRRSexo>> ObtenerSexoId(int id)
        {
            return await this._SexoRepository.ObtenerSexoId(id);
        }
        public async Task<List<HHRRSexo>> CrearSexo(string NombreSexo)
        {
            return await this._SexoRepository.CrearSexoId(NombreSexo);
        }
        public async Task<List<HHRRSexo>> ModificarSexoId(string NombreSexo, int id)
        {
            return await this._SexoRepository.ModificarSexo(NombreSexo, id);
        }
        public async Task<List<HHRRSexo>> EliminarSexoId(int id)
        {
            return await this._SexoRepository.EliminarSexo(id);
        }
    }
}