using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class CargoQuery
    {
        public string ObtenerCargo()
        {
            return @$"
                SELECT id,`NombreCargo` FROM hhrrcargo;
            ";
        }
        public string ObtenerCargoId(int id)
        {
            return @$"
                SELECT id,`NombreCargo` FROM hhrrcargo
                WHERE
                    id='{id}'
            ";
        }
        public string GuardarCargo(string NombreCargo)
        {
            return @$"
            insert into
                hhrrcargo (`NombreCargo`)
            values ( '{NombreCargo}');
            ";
        }
        public string ModificarCargo(string NombreCargo, int id)
        {
            return @$"
                update hhrrcargo
                set
                    NombreCargo = '{NombreCargo}'
                where id = '{id}';
                ";
        }
        public string EliminarCargo(int id)
        {
            return @$"
                 delete from hhrrcargo where id = {id};
            ";
        }
    }
}