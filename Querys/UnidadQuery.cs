using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class UnidadQuery
    {
        public string ObtenerUnidad()
        {
            return @$"
                SELECT id,`NombreUnidad` FROM hhrrunidad;
            ";
        }
        public string ObtenerUnidadId(int id)
        {
            return @$"
                SELECT id,`NombreUnidad` FROM hhrrunidad
                WHERE
                    id='{id}'
            ";
        }
        public string GuardarUnidad(string NombreUnidad)
        {
            return @$"
            insert into
                hhrrunidad (`NombreUnidad`)
            values ( '{NombreUnidad}');
            ";
        }
        public string ModificarUnidad(string NombreUnidad, int id)
        {
            return @$"
                update hhrrunidad
                set
                    NombreUnidad = '{NombreUnidad}'
                where id = '{id}';
                ";
        }
        public string EliminarUnidad(int id)
        {
            return @$"
                 delete from hhrrunidad where id = {id};
            ";
        }
    }
}