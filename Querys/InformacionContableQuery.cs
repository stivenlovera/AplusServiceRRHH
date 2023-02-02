using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class InformacionContableQuery
    {
        public string ObtenerInformacionContable()
        {
            return @$"
                SELECT id,`NombreInformacionContable` FROM hhrrinformacioncontable;
            ";
        }
        public string ObtenerInformacionContableId(int id)
        {
            return @$"
               SELECT id,`NombreInformacionContable` FROM hhrrinformacioncontable WHERE id='{id}';
            ";
        }
        public string GuardarInformacionContable(string NombreInformacionContable)
        {
            return @$"
                insert into 
                hhrrinformacioncontable (
                    `NombreInformacionContable`
                )
                values
                (
                    '{NombreInformacionContable}'
                );
            ";
        }
        public string ModificarInformacionContable(string NombreInformacionContable, int id)
        {
            return @$" 
            update 
                hhrrinformacioncontable 
            set 
                NombreInformacionContable = '{NombreInformacionContable}'
            where 
                id = '{id}';
            ";
        }
        public string EliminarInformacionContable(int id)
        {
            return @$"
                delete from 
                    hhrrinformacioncontable 
                where 
                    id = '{id}';
            ";
        }
    }
}