using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class BancosQuery
    {
        public string ObtenerBanco()
        {
            return @$"
               SELECT id,`NombreBanco` FROM hhrrbanco;
            ";
        }
        public string ObtenerBancoId(int id)
        {
            return @$"
              SELECT id,`NombreBanco` FROM hhrrbanco WHERE id='{id}';
            ";
        }
        public string GuardarBanco(string NombreBanco)
        {
            return @$"
                insert into
                    hhrrbanco (`NombreBanco`)
                values ('{NombreBanco}');
            ";
        }
        public string ModificarBanco(string NombreBanco, int id)
        {
            return @$"
              update hhrrbanco set NombreBanco = '{NombreBanco}' where id = '{id}';
            ";
        }
        public string EliminarBanco(int id)
        {
            return @$"
               delete from hhrrbanco where id = '{id}';
            ";
        }
    }
}