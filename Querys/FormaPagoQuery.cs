using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class FormaPagoQuery
    {
         public string ObtenerFormaPago()
        {
            return @$"
               SELECT id,`NombreFormaPago` FROM hhrrformapago;
            ";
        }
        public string ObtenerFormaPagoId(int id)
        {
            return @$"
              SELECT id,`NombreFormaPago` FROM hhrrformapago WHERE id='{id}';
            ";
        }
        public string GuardarFormaPago(string NombreFormaPago)
        {
            return @$"
               insert into
                    hhrrformapago ( `NombreFormaPago`)
                values ('{NombreFormaPago}');
            ";
        }
        public string ModificarFormaPago(string NombreFormaPago, int id)
        {
            return @$"
                update hhrrformapago
                set
                    NombreFormaPago = '{NombreFormaPago}'
                where id = '{id}';
            ";
        }
        public string EliminarFormaPago(int id)
        {
            return @$"
                delete from hhrrformapago 
                where 
                    id = '{id}';
            ";
        }
    }
}