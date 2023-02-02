using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class ColaboradorQuery
    {
        public string ObtenerColaborador()
        {
            return @$"
               SELECT * FROM hhrrcolaborador;
            ";
        }
        public string ObtenerColaboradorId(int id)
        {
            return @$"
               SELECT id,`NombreColaborador` FROM hhrrColaborador WHERE id='{id}';
            ";
        }
        public string GuardarColaborador(string NombreColaborador)
        {
            return @$"
                insert into 
                hhrrColaborador (
                    `NombreColaborador`
                )
                values
                (
                    '{NombreColaborador}'
                );
            ";
        }
        public string ModificarColaborador(string NombreColaborador, int id)
        {
            return @$"
            update 
                hhrrColaborador 
            set 
                NombreColaborador = '{NombreColaborador}'
            where 
                id = '{id}';
            ";
        }
        public string EliminarColaborador(int id)
        {
            return @$"
                delete from 
                    hhrrColaborador 
                where 
                    id = '{id}';
            ";
        }
        public string DatatableColaborador()
        {
            return @$"
                SELECT
                    c.id,
                    c.ci,
                    c.CodigoColaborador,
                    c.Nombre1,
                    c.Nombre2,
                    c.Nombre3,
                    c.ApellidoPaterno,
                    c.ApellidoMaterno,
                    c.ApellidoCasado,
                    cargo.NombreCargo,
                    unidad.NombreUnidad,
                    sucursal.NombreSucursal,
                    oficina.NombreOficina
                FROM hhrrcolaborador as c
                    inner JOIN hhrrcargo as cargo on cargo.id = c.Cargo
                    INNER JOIN hhrrunidad as unidad on unidad.id = c.Unidad
                    INNER JOIN hhrrsucursal as sucursal on sucursal.id = c.Sucursal
                    INNER JOIN hhrroficina as oficina on c.Oficina = oficina.id
            ";
        }
    }
}