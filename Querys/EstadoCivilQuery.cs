using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class EstadoCivilQuery
    {
        public string ObtenerEstadoCivil()
        {
            return @$"
               SELECT id,`NombreEstadoCivil` FROM hhrrestadocivil;
            ";
        }
        public string ObtenerEstadoCivilId(int id)
        {
            return @$"
               SELECT id,`NombreEstadoCivil` FROM hhrrestadocivil WHERE id='{id}';
            ";
        }
        public string GuardarEstadoCivil(string NombreEstadoCivil)
        {
            return @$"
                insert into 
                hhrrestadocivil (
                    `NombreEstadoCivil`
                )
                values
                (
                    '{NombreEstadoCivil}'
                );
            ";
        }
        public string ModificarEstadoCivil(string NombreEstadoCivil, int id)
        {
            return @$"
                update 
                    hhrrestadocivil 
                set 
                    NombreEstadoCivil = '{NombreEstadoCivil}'
                where 
                    id = '{id}';
            ";
        }
        public string EliminarEstadoCivil(int id)
        {
            return @$"
                delete from 
                    hhrrestadocivil 
                where 
                    id = '{id}';
            ";
        }
    }
}