using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class UsuarioRolQuery
    {
        public string UsuarioRol()
        {
            return @"
                SELECT * FROM hhrrusuariorol;
            ";
        }
        public string ObtenerUsuarioId(int usuarioId)
        {
            return @$"
                SELECT * FROM hhrrusuariorol
                WHERE
                    HHRRUsuarioId='{usuarioId}'
            ";
        }
        public string ObtenerRolId(int rolId)
        {
            return @$"
                SELECT * FROM hhrrusuariorol
                WHERE
                    HHRRRolId='{rolId}'
            ";
        }
        public string GuardarRol(int rolId, int usuarioId)
        {
            return @$"
            insert into
                hhrrusuariorol (
                    HHRRRolId,
                    HHRRUsuarioId
                )
            values (
                    '{rolId}',
                    '{usuarioId}'
                );
            ";
        }
        public string ModificarUsuarioId(int id, int rolId, int usuarioId)
        {
            return @$"
                update hhrrusuariorol
                set
                    HHRRUsuarioId='{usuarioId}'
                where HHRRRolId = '{rolId}';
                ";
        }
        public string ModificarRolId(int id, int rolId, int usuarioId)
        {
            return @$"
                update hhrrusuariorol
                set
                    HHRRUsuarioId='{usuarioId}'
                where HHRRRolId = '{rolId}';
                ";
        }
        public string EliminarRolId(int rolId)
        {
            return @$"
                delete from hhrrusuariorol where HHRRRolId = '{rolId}';
            ";
        }
          public string EliminarUsuarioId(int usuarioId)
        {
            return @$"
                delete from hhrrusuariorol where HHRRUsuarioId = '{usuarioId}';
            ";
        }
    }
}