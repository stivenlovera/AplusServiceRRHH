using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class AdministracionPesionQuery
    {
         public string ObtenerAdministracionPesion()
        {
            return @$"
               SELECT id,`NombreAdministracionPesion` FROM hhrradministracionpesion;
            ";
        }
        public string ObtenerAdministracionPesionId(int id)
        {
             return @$"
               SELECT id,`NombreAdministracionPesion` FROM hhrradministracionpesion WHERE id='{id}'
            ";
        }
        public string GuardarAdministracionPesion(string NombreAdministracionPesion)
        {
          return @$"
                insert into
                    hhrradministracionpesion (
                        `NombreAdministracionPesion`
                    )
                values (
                        '{NombreAdministracionPesion}'
                    );
            ";
        }
        public string ModificarAdministracionPesion(string NombreAdministracionPesion, int id)
        {
            return @$"
                update
                    hhrradministracionpesion
                set
                    NombreAdministracionPesion = '{NombreAdministracionPesion}'
                where id = '{id}';
            ";
        }
        public string EliminarAdministracionPesion(int id)
        {
            return @$"
               delete from hhrradministracionpesion where id = '{id}'
            ";
        }
    }
}