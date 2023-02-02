using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class DepartamentoModule
    {
        private readonly ILogger<DepartamentoModule> _logger;
        private readonly DepartamentoRepositorio _departamentoRepositorio;

        public DepartamentoModule(
               ILogger<DepartamentoModule> logger,
               DepartamentoRepositorio departamentoRepositorio
        )
        {
            this._logger = logger;
            this._departamentoRepositorio = departamentoRepositorio;
        }
        public async Task<List<HHRRDepartamento>> ObtenerDepartamentos()
        {
            return await this._departamentoRepositorio.ObtenerDepartamentos();
        }
        public async Task<List<HHRRDepartamento>> ObtenerDepartamentoId(int id)
        {
            return await this._departamentoRepositorio.ObtenerDepartamentoId(id);
        }
        public async Task<List<HHRRDepartamento>> CrearTipoDocumento(string NombreTipoDocumento, int PaisId)
        {
            return await this._departamentoRepositorio.CrearDepartamentoId(NombreTipoDocumento, PaisId);
        }
        public async Task<List<HHRRDepartamento>> ModificarTipoDocumentoId(string NombreTipoDocumento, int PaisId, int id)
        {
            return await this._departamentoRepositorio.ModificarDepartamento(NombreTipoDocumento, PaisId, id);
        }
        public async Task<List<HHRRDepartamento>> EliminarTipoDocumentoId(int id)
        {
            return await this._departamentoRepositorio.EliminarDepartamento(id);
        }
    }
}