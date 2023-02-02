using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class SucursalModule
    {
        private readonly ILogger<SucursalModule> _logger;
        private readonly SucursalRepository _SucursalRepository;

        public SucursalModule(
            ILogger<SucursalModule> logger,
            SucursalRepository SucursalRepository
        )
        {
            this._logger = logger;
            this._SucursalRepository = SucursalRepository;
        }
        public async Task<List<HHRRSucursal>> ObtenerSucursal()
        {
            return await this._SucursalRepository.ObtenerSucursal();
        }
        public async Task<List<HHRRSucursal>> ObtenerSucursalId(int id)
        {
            return await this._SucursalRepository.ObtenerSucursalId(id);
        }
        public async Task<List<HHRRSucursal>> CrearSucursal(string NombreSucursal,string Dirreccion)
        {
            return await this._SucursalRepository.CrearSucursal(NombreSucursal,Dirreccion);
        }
        public async Task<List<HHRRSucursal>> ModificarSucursalId(string NombreSucursal,string Dirreccion, int id)
        {
            return await this._SucursalRepository.ModificarSucursal(NombreSucursal,Dirreccion, id);
        }
        public async Task<List<HHRRSucursal>> EliminarSucursalId(int id)
        {
            return await this._SucursalRepository.EliminarSucursal(id);
        } 
    }
}