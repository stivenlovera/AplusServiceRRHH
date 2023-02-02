using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class ClasificacionLaboralQuery
    {
        public string ObtenerClasificacionLaboral()
        {
            return @$"
               SELECT id,`NombreClasificacionLaboral` FROM hhrrclasificacionlaboral;
            ";
        }
        public string ObtenerClasificacionLaboralId(int id)
        {
            return @$"
               SELECT id,`NombreClasificacionLaboral` FROM hhrrclasificacionlaboral WHERE id='{id}';
            ";
        }
        public string GuardarClasificacionLaboral(string NombreClasificacionLaboral)
        {
            return @$"
                insert into 
                hhrrclasificacionlaboral (
                    `NombreClasificacionLaboral`
                )
                values
                (
                    '{NombreClasificacionLaboral}'
                );
            ";
        }
        public string ModificarClasificacionLaboral(string NombreClasificacionLaboral, int id)
        {
            return @$"
            update 
                hhrrclasificacionlaboral 
            set 
                NombreClasificacionLaboral = '{NombreClasificacionLaboral}'
            where 
                id = '{id}';
            ";
        }
        public string EliminarClasificacionLaboral(int id)
        {
            return @$"
                delete from 
                    hhrrclasificacionlaboral 
                where 
                    id = '{id}';
            ";
        }
    }
}