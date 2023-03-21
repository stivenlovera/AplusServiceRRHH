using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class UsuarioQuery
    {
        public string Login(string usuario, string contrasena)
        {
            return @$"
                SELECT
                    u.id,
                    u.usuario,
                    u.contrasena,
                    u.HHRRcolaboradorId,
                    c.Nombre1,
                    c.Nombre2,
                    c.Nombre3,
                    c.ApellidoPaterno,
                    c.ApellidoMaterno,
                    c.ApellidoCasado
                FROM hhrrusuario as u
                    INNER JOIN hhrrcolaborador as c on c.Id = u.HHRRcolaboradorId
                WHERE
                    contrasena = '{contrasena}'
                    and usuario = '{usuario}';
            ";
        }
        public string DataTableUsuario()
        {
            return @"
                SELECT U.id, c.Nombre1,c.Nombre2,c.Nombre3,c.ApellidoPaterno,c.ApellidoMaterno, c.ApellidoCasado,u.usuario,u.contrasena,rol.nombre as nombreRol FROM hhrrusuario as u INNER JOIN hhrrusuariorol as ur on u.id=ur.HHRRUsuarioId INNER JOIN hhrrrol as rol on rol.id=ur.HHRRRolId INNER JOIN hhrrcolaborador c on c.Id=u.HHRRcolaboradorId;
            ";
        }
        public string ObtenerUsuarioId(int id)
        {
            return @$"
                SELECT * FROM HHRRUsuario
                WHERE
                    id='{id}'
            ";
        }
        public string GuardarUsuario(string usuario, string contrasena, int HHRRcolaboradorId)
        {
            return @$"
            insert into
                hhrrusuario (
                    usuario,
                    contrasena,
                    HHRRcolaboradorId
                )
            values (
                    '{usuario}',
                    '{contrasena}',
                    '{HHRRcolaboradorId}'
                );
            ";
        }
        public string ModificarUsuario(int id, string usuario, string contrasena, int HHRRcolaboradorId)
        {
            return @$"
                update hhrrusuario
                set
                    usuario = '{usuario}',
                    contrasena = '{contrasena}',
                    HHRRcolaboradorId = '{HHRRcolaboradorId}'
                where id = '{id}';
                ";
        }
        public string EliminarUsuario(int id)
        {
            return @$"
                delete from hhrrusuario where id = '{id}';
            ";
        }
    }
}