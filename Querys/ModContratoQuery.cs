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
               SELECT id,`NombreModContrato` FROM hhrrmodcontrato;
            ";
        }
        public string ObtenerModContratoId(int id)
        {
            return @$"
              SELECT id,`NombreModContrato` FROM hhrrmodcontrato WHERE id='{id}';
            ";
        }
        public string GuardarModContrato(string NombreModContrato)
        {
            return @$"
                insert into 
                hhrrmodcontrato ( 
                    `NombreModContrato`
                )
                values
                (
                    '{NombreModContrato}'
                );
            ";
        }
        public string ModificarModContrato(string NombreModContrato, int id)
        {
            return @$"
                update 
                    hhrrmodcontrato 
                set 
                    NombreModContrato = '{NombreModContrato}'
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