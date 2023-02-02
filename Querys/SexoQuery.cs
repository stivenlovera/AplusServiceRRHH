using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class SexoQuery
    {
        public string ObtenerSexo()
        {
            return @$"
                SELECT id,`NombreSexo` FROM hhrrsexo;
            ";
        }
        public string ObtenerSexoId(int id)
        {
            return @$"
               SELECT id,`NombreSexo` FROM hhrrsexo WHERE id='{id}';
            ";
        }
        public string GuardarSexo(string NombreSexo)
        {
            return @$"
              insert into 
                hhrrsexo (
                    `NombreSexo`
                )
                values
                (
                    '{NombreSexo}'
                );
            ";
        }
        public string ModificarSexo(string NombreSexo, int id)
        {
            return @$"
            update 
                hhrrsexo 
            set 
                NombreSexo = '{NombreSexo}'
            where 
                id = '{id}';
            ";
        }
        public string EliminarSexo(int id)
        {
            return @$"
                delete from 
                    hhrrsexo 
                where 
                    id = '{id}';
            ";
        }
    }
}