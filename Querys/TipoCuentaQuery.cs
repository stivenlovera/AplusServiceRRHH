using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class TipoCuentaQuery
    {
       public string ObtenerTipoCuenta()
        {
            return @$"
               SELECT id,`NombreTipoCuenta` FROM hhrrTipoCuenta;
            ";
        }
        public string ObtenerTipoCuentaId(int id)
        {
            return @$"
              SELECT id,`NombreTipoCuenta` FROM hhrrTipoCuenta WHERE id='{id}';
            ";
        }
        public string GuardarTipoCuenta(string NombreTipoCuenta)
        {
            return @$"
                insert into
                    hhrrTipoCuenta (`NombreTipoCuenta`)
                values ('{NombreTipoCuenta}');
            ";
        }
        public string ModificarTipoCuenta(string NombreTipoCuenta, int id)
        {
            return @$"
               update hhrrTipoCuenta set NombreTipoCuenta = NombreTipoCuenta where id = '{id}';
            ";
        }
        public string EliminarTipoCuenta(int id)
        {
            return @$"
               delete from hhrrTipoCuenta where id = '{id}';
            ";
        }
    }
}