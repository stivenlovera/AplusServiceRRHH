using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class AsistenciaQuery
    {
        public string DataTable()
        {
            return $@"
                SELECT
                    asistencia.*,
                    c.CodigoColaborador,
                    c.`Nombre1`,
                    c.`Nombre2`,
                    c.`Nombre3`,
                    c.`ApellidoPaterno`,
                    c.`ApellidoMaterno`,
                    c.`ApellidoCasado`,
                    cargo.`NombreCargo`
                FROM
                    hhrrasistencia as asistencia
                    inner JOIN hhrrcolaborador as c on c.`Id` = asistencia.id
                    inner JOIN hhrrcargo as cargo on c.`Id` = cargo.id;
            ";
        }
        public string ObtenerAsistencia()
        {
            return @$"
                SELECT * FROM hhrrasistencia;
            ";
        }
        public string ObtenerAsistenciaId(int id)
        {
            return @$"
                SELECT * FROM hhrrasistencia
                WHERE
                    id='{id}'
            ";
        }
        public string GuardarAsistencia(
            DateTime fechaRegistro,
            DateTime? fechaEntrada,
            DateTime? fechaSalida,
            DateTime? horaEntrada,
            DateTime? horaSalida,
            string nota,
            int HHRRColaboradorId
            )
        {
            string fechaEntradaNull = fechaEntrada == null ? "null" : ($"'{fechaEntrada?.ToString("yyyy-MM-dd")}'");
            string fechaSalidaNull = fechaSalida == null ? "null" : ($"'{fechaSalida?.ToString("yyyy-MM-dd")}'");
            string horaEntradaNull = horaEntrada == null ? "null" : ($"'{horaEntrada?.ToString("HH:mm:ss")}'");
            string horaSalidaNull = horaSalida == null ? "null" : ($"'{horaSalida?.ToString("HH:mm:ss")}'");
            
            return @$"
            insert into
                hhrrasistencia (
                    fechaRegistro,
                    fechaEntrada,
                    fechaSalida,
                    horaEntrada,
                    horaSalida,
                    nota,
                    HHRRColaboradorId
                )
            values (
                    '{fechaRegistro}',
                    '{fechaEntrada}',
                    '{fechaSalida}',
                    '{horaEntrada}',
                    '{horaSalida}',
                    '{nota}',
                    '{HHRRColaboradorId}'
                );

            ";
        }
        public string ModificarAsistencia(
            int id,
            DateTime fechaRegistro,
            DateTime? fechaEntrada,
            DateTime? fechaSalida,
            DateTime? horaEntrada,
            DateTime? horaSalida,
            string nota,
            int HHRRColaboradorId
            )
        {
            string fechaEntradaNull = fechaEntrada == null ? "null" : ($"'{fechaEntrada?.ToString("yyyy-MM-dd")}'");
            string fechaSalidaNull = fechaSalida == null ? "null" : ($"'{fechaSalida?.ToString("yyyy-MM-dd")}'");
            string horaEntradaNull = horaEntrada == null ? "null" : ($"'{horaEntrada?.ToString("HH:mm:ss")}'");
            string horaSalidaNull = horaSalida == null ? "null" : ($"'{horaSalida?.ToString("HH:mm:ss")}'");
            return @$"
                update
                    hhrrasistencia
                set
                    fechaRegistro = '{fechaRegistro}',
                    fechaEntrada = '{fechaEntrada}',
                    fechaSalida = '{fechaSalida}',
                    horaEntrada = '{horaEntrada}',
                    horaSalida = '{horaSalida}',
                    nota = '{nota}',
                    HHRRColaboradorId = '{HHRRColaboradorId}'
                where id = '{id}';
                ";
        }
        public string EliminarAsistencia(int id)
        {
            return @$"
                delete from
                    hhrrasistencia
                where id = '{id}';
            ";
        }
    }
}