using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class FormacionPrincipalQuery
    {
        public string ObtenerFormacionPrincipal()
        {
            return @$"
               SELECT id,`NombreFormacionPrincipal` FROM hhrrformacionprincipal;
            ";
        }
        public string ObtenerFormacionPrincipalId(int id)
        {
            return @$"
              SELECT id,`NombreFormacionPrincipal` FROM hhrrformacionprincipal WHERE id='{id}';
            ";
        }
        public string GuardarFormacionPrincipal(string NombreFormacionPrincipal)
        {
            return @$"
                insert into
                    hhrrformacionprincipal (
                        `NombreFormacionPrincipal`
                    )
                values (
                        '{NombreFormacionPrincipal}'
                    );
            ";
        }
        public string ModificarFormacionPrincipal(string NombreFormacionPrincipal, int id)
        {
            return @$"
                update hhrrformacionprincipal
                set
                    NombreFormacionPrincipal = '{NombreFormacionPrincipal}'
                where id = '{id}';
            ";
        }
        public string EliminarFormacionPrincipal(int id)
        {
            return @$"
                delete from hhrrformacionprincipal where id = {id};
            ";
        }
    }
}