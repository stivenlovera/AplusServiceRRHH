using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class SucursalQuery
    {
        public string ObtenerSucursal()
        {
            return @$"
                SELECT id,`NombreSucursal`,`Direccion` FROM hhrrsucursal;
            ";
        }
        public string ObtenerSucursalId(int id)
        {
            return @$"
               SELECT id,`NombreSucursal`,`Direccion` FROM hhrrsucursal WHERE id='{id}';
            ";
        }
        public string GuardarSucursal(string NombreSucursal, string Direccion)
        {
            return @$"
            insert into 
            hhrrsucursal (
                `NombreSucursal`, 
                `Direccion`
            )
            values
            (
                '{NombreSucursal}', 
                '{Direccion}'
            );
            ";
        }
        public string ModificarSucursal(string NombreSucursal, string Direccion, int id)
        {
            return @$"
            update 
                hhrrsucursal 
            set 
                NombreSucursal = '{NombreSucursal}',
                Direccion = '{Direccion}'
            where 
                id = '{id}';
            ";
        }
        public string EliminarSucursal(int id)
        {
            return @$"
                delete from 
                    hhrrsucursal 
                where 
                    id = '{id}';
            ";
        }
    }
}