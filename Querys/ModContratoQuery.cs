using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class ModContratoQuery
    {
        public string ObtenerModContrato()
        {
            return @$"
               SELECT id,`NombreModContrato`,dias FROM hhrrmodcontrato;
            ";
        }
        public string ObtenerModContratoId(int id)
        {
            return @$"
              SELECT id,`NombreModContrato`,dias FROM hhrrmodcontrato WHERE id='{id}';
            ";
        }
        public string GuardarModContrato(string NombreModContrato, int dias)
        {
            return @$"
                insert into 
                hhrrmodcontrato ( 
                    `NombreModContrato`,
                    dias
                )
                values
                (
                    '{NombreModContrato}',
                    '{dias}'
                );
            ";
        }
        public string ModificarModContrato(string NombreModContrato, int dias, int id)
        {
            return @$"
                update 
                    hhrrmodcontrato 
                set 
                    NombreModContrato = '{NombreModContrato}',
                    dias = '{dias}'
                where 
                    id = '{id}';
            ";
        }
        public string EliminarModContrato(int id)
        {
            return @$"
                delete from 
                    hhrrmodcontrato 
                where 
                    id = '{id}';
            ";
        }
    }
}