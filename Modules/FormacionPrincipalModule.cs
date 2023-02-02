using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class FormacionPrincipalModule
    {
         private readonly ILogger<FormacionPrincipalModule> _logger;
        private readonly FormacionPrincipalRepository _FormacionPrincipalRepository;

        public FormacionPrincipalModule(
            ILogger<FormacionPrincipalModule> logger,
            FormacionPrincipalRepository FormacionPrincipalRepository
        )
        {
            this._logger = logger;
            this._FormacionPrincipalRepository = FormacionPrincipalRepository;
        }
        public async Task<List<HHRRFormacionPrincipal>> ObtenerFormacionPrincipal()
        {
            return await this._FormacionPrincipalRepository.ObtenerFormacionPrincipal();
        }
        public async Task<List<HHRRFormacionPrincipal>> ObtenerFormacionPrincipalId(int id)
        {
            return await this._FormacionPrincipalRepository.ObtenerFormacionPrincipalId(id);
        }
        public async Task<List<HHRRFormacionPrincipal>> CrearFormacionPrincipal(string NombreFormacionPrincipal)
        {
            return await this._FormacionPrincipalRepository.CrearFormacionPrincipalId(NombreFormacionPrincipal);
        }
        public async Task<List<HHRRFormacionPrincipal>> ModificarFormacionPrincipalId(string NombreFormacionPrincipal, int id)
        {
            return await this._FormacionPrincipalRepository.ModificarFormacionPrincipal(NombreFormacionPrincipal, id);
        }
        public async Task<List<HHRRFormacionPrincipal>> EliminarFormacionPrincipalId(int id)
        {
            return await this._FormacionPrincipalRepository.EliminarFormacionPrincipal(id);
        }
    }
}