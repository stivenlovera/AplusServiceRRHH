using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class ColaboradorModule
    {
        private readonly ILogger<ColaboradorModule> _logger;
        private readonly ColaboradorRepository _colaboradorRepository;

        public ColaboradorModule(
            ILogger<ColaboradorModule> logger,
            ColaboradorRepository colaboradorRepository
        )
        {
            this._logger = logger;
            this._colaboradorRepository = colaboradorRepository;
        }
        public async Task<List<ColaboradorDataTable>> ObtenerColaborador()
        {
            return await this._colaboradorRepository.DatatableColaborador();

        }
        public async Task<List<HHRRColaborador>> ObtenerColaboradorId(int id)
        {
            return await this._colaboradorRepository.ObtenerColaboradorId(id);
        }
        public async Task<List<HHRRColaborador>> CrearColaborador(string NombreColaborador)
        {
            return await this._colaboradorRepository.CrearColaboradorId(NombreColaborador);
        }
        public async Task<List<HHRRColaborador>> ModificarColaboradorId(string NombreColaborador, int id)
        {
            return await this._colaboradorRepository.ModificarColaborador(NombreColaborador, id);
        }
        public async Task<List<HHRRColaborador>> EliminarColaboradorId(int id)
        {
            return await this._colaboradorRepository.EliminarColaborador(id);
        }
    }
}