using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class TipoContratoQuery
    {
        public string ObtenerTipoContrato()
        {
            return @$"
                SELECT id,`NombreTipoContrato` FROM hhrrtipocontrato;
            ";
        }
        public string ObtenerTipoContratoId(int id)
        {
            return @$"
               SELECT id, NombreTipoContrato as nombreModalidad FROM hhrrtipocontrato WHERE id='{id}';
            ";
        }
        public string GuardarTipoContrato(string NombreTipoContrato)
        {
            return @$"
                insert into 
                hhrrtipocontrato (
                    `NombreTipoContrato`
                )
                values
                (
                    '{NombreTipoContrato}'
                );
            ";
        }
        public string ModificarTipoContrato(string NombreTipoContrato, int id)
        {
            return @$"
                update 
                    hhrrtipocontrato 
                set 
                    NombreTipoContrato = '{NombreTipoContrato}'
                where 
                    id = '{id}';
            ";
        }
        public string EliminarTipoContrato(int id)
        {
            return @$"
                delete from 
                    hhrrtipocontrato 
                where 
                    id = '{id}';
            ";
        }
    }
}