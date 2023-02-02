using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class CajaSaludQuery
    {
         public string ObtenerCajaSalud()
        {
            return @$"
              SELECT id,`NombreCajaSalud` FROM hhrrcajasalud;
            ";
        }
        public string ObtenerCajaSaludId(int id)
        {
            return @$"
              SELECT id,`NombreCajaSalud` FROM hhrrcajasalud WHERE id='{id}';
            ";
        }
        public string GuardarCajaSalud(string NombreCajaSalud)
        {
            return @$"
                insert into
                    hhrrcajasalud ( `NombreCajaSalud`)
                values ('{NombreCajaSalud}');
            ";
        }
        public string ModificarCajaSalud(string NombreCajaSalud, int id)
        {
            return @$"
                update hhrrcajasalud
                set
                    NombreCajaSalud = '{NombreCajaSalud}'
                where id = '{id}';
            ";
        }
        public string EliminarCajaSalud(int id)
        {
            return @$"
                delete from hhrrcajasalud where id = '{id}';
            ";
        }
    }
}