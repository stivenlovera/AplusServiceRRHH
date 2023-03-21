using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class RolQuery
    {
         public string DataTableRol()
        {
            return @"
                SELECT * FROM hhrrrol;
            ";
        }
          public string ObtenerRolId(int id)
        {
            return @$"
                SELECT * FROM hhrrrol
                WHERE
                    id='{id}'
            ";
        }
        public string GuardarRol(string nombre, string descripcion)
        {
            return @$"
                insert into
                    hhrrrol ( nombre, descripcion)
                values ( '{nombre}', '{descripcion}');
            ";
        }
        public string ModificarRol(int id,string nombre, string descripcion)
        {
            return @$"
                update
                    hhrrrol
                set
                    nombre = '{nombre}',
                    descripcion = '{descripcion}'
                where id = '{id}';
                ";
        }
        public string EliminarRol(int id)
        {
            return @$"
                delete from hhrrrol where id = '{id}';
            ";
        }
    }
}