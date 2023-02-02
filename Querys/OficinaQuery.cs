using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class OficinaQuery
    {
        public string ObtenerOficina()
        {
            return @$"
                SELECT id,`NombreOficina`,`HHRRSucursalId` FROM hhrroficina;
            ";
        }
        public string ObtenerOficinaId(int id)
        {
            return @$"
               SELECT id,`NombreOficina`,`HHRRSucursalId` FROM hhrroficina WHERE id='{id}';
            ";
        }
        public string GuardarOficina(string NombreOficina, int HHRRSucursalId)
        {
            return @$"
                insert into 
                hhrroficina (
                    `NombreOficina`, 
                    `HHRRSucursalId`
                )
                values
                (
                    '{NombreOficina}', 
                    '{HHRRSucursalId}'
                );
  
            ";
        }
        public string ModificarOficina(string NombreOficina, int HHRRSucursalId, int id)
        {
            return @$"
                 update 
                    hhrroficina 
                set 
                    NombreOficina = '{NombreOficina}',
                    HHRRSucursalId = '{HHRRSucursalId}'
                where 
                    id = '{id}';
    
            ";
        }
        public string EliminarOficina(int id)
        {
            return @$"
                delete from 
                    hhrroficina 
                where 
                    id = '{id}';
            ";
        }
    }
}