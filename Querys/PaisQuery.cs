using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class PaisQuery
    {
        public string ObtenerPais()
        {
            return @$"
                SELECT id,NombrePais FROM hhrrpais;
            ";
        }
        public string ObtenerPaisId(int id)
        {
            return @$"
               SELECT id,NombrePais FROM hhrrpais WHERE id='{id}';
            ";
        }
        public string GuardarPais(string NombrePais)
        {
            return @$"
                insert into
                    hhrrpais ( NombrePais)
                values ({NombrePais});
            ";
        }
        public string ModificarPais(string NombrePais, int id)
        {
            return @$"
                update 
                    hhrrpais 
                set 
                    NombrePais = '{NombrePais}'
                where 
                    id = '{id}';
            ";
        }
        public string EliminarPais(int id)
        {
            return @$"
                delete from 
                    hhrrpais 
                where 
                    id = '{id}';
            ";
        }
    }
}