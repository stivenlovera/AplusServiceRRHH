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
               SELECT id,NombreColaborador FROM hhrrColaborador WHERE id='{id}';
            ";
        }
        public string GuardarColaborador(
                        string Ci,
                        string Nombre1,
                        string Nombre2,
                        string Nombre3,
                        string ApellidoPaterno,
                        string ApellidoMaterno,
                        string ApellidoCasado,
                        DateTime FechaNacimiento,
                        DateTime VencimientoDocumento,
                        DateTime VencimientoLicConducir,
                        string LugarNacimiento,
                        string LicenciaConducir,
                        string TelefonoFijo,
                        string Celular,
                        string TelefonoFijoTrabajo,
                        string ContactoEmegencia,
                        string TelefonoEmergencia,
                        string ViviendaPropia,
                        string VehiculoPropio,
                        string TipoSangre,
                        string FactorSangre,
                        string Dirrecion,
                        string Email,
                        int TipoDocumento,
                        int Nacionalidad,
                        int Departamento,
                        int EstadoCivil,
                        string ConyugeNombreCompleto,
                        string ConyugeLugarNacimiento,
                        DateTime ConyugeFechaNacimiento,
                        string CodigoColaborador,
                        DateTime FechaIngreso,
                        DateTime FechaIngresoVacaciones,
                        DateTime FechaIngresoVacacionesAnt,
                        DateTime FechaIngresoBonoAntiguedad,
                        string Oficina,
                        string ModohaberBasico,
                        string HaberBasico,
                        string ModoQuincena,
                        string HaberQuincena,
                        string TelefonoLaboral,
                        string CelularLaboral,
                        string DirrecionLaboral,
                        string EmailLaboral,
                        string MotivoContrato,
                        int ModoContrato,
                        DateTime FechaFinalizacion,
                        DateTime FechaRatificacion,
                        string ExcliblePlanilla,
                        string AguinaldoMes1,
                        string Aplica2aguinaldo,
                        string AplicaRetroactivos,
                        string AplicaPrima,
                        string EnviarBoletaPago,
                        string Indemnizacion,
                        string PorcentajeCentroCosto,
                        string CuentaBancaria,
                        string AplicaAFP,
                        string NroAFP,
                        string Jubilado,
                        string AportaAFP,
                        string AplicaCajaSalud,
                        string NroAsegurado,
                        string Discapacidad,
                        string RequiereApruebeVacaciones,
                        string ValorLunes,
                        string ValorMartes,
                        string ValorMiercoles,
                        string ValorJueves,
                        string ValorViernes,
                        string ValorSabado,
                        string ValorDomingo,
                        string CodigoAsistencia,
                        string DiasporMes,
                        string ControlarAsistencia,
                        string BonoExtra,
                        string BonoExtraNocturna,
                        string HorasParaHorasExtras,
                        string HorasPorDia,
                        string DescuentoPorFalta,
                        string DescuentoPorAtraso,
                        string Dominicales,
                        string TrabajaDomingo,
                        string HorasPlanillas,
                        int Unidad,
                        int Sucursal,
                        int Cargo,
                        int Clasificacionlaboral,
                        int TipoContrato,
                        int InformacionContable,
                        int CentroCosto,
                        int FormaPago,
                        int TipoCuenta,
                        int Banco,
                        int AdministracionPensiones,
                        int CajaSalud,
                        int FormacionPrincial,
                        int Sexo
        )
        {
            return @$"
                INSERT INTO
                    hhrrcolaborador(
                        Ci,
                        Nombre1,
                        Nombre2,
                        Nombre3,
                        ApellidoPaterno,
                        ApellidoMaterno,
                        ApellidoCasado,
                        FechaNacimiento,
                        VencimientoDocumento,
                        VencimientoLicConducir,
                        LugarNacimiento,
                        LicenciaConducir,
                        TelefonoFijo,
                        Celular,
                        TelefonoFijoTrabajo,
                        ContactoEmegencia,
                        TelefonoEmergencia,
                        ViviendaPropia,
                        VehiculoPropio,
                        TipoSangre,
                        FactorSangre,
                        Dirrecion,
                        Email,
                        TipoDocumento,
                        Nacionalidad,
                        Departamento,
                        EstadoCivil,
                        ConyugeNombreCompleto,
                        ConyugeLugarNacimiento,
                        ConyugeFechaNacimiento,
                        CodigoColaborador,
                        FechaIngreso,
                        FechaIngresoVacaciones,
                        FechaIngresoVacacionesAnt,
                        FechaIngresoBonoAntiguedad,
                        Oficina,
                        ModohaberBasico,
                        HaberBasico,
                        ModoQuincena,
                        HaberQuincena,
                        TelefonoLaboral,
                        CelularLaboral,
                        DirrecionLaboral,
                        EmailLaboral,
                        MotivoContrato,
                        ModoContrato,
                        FechaFinalizacion,
                        FechaRatificacion,
                        ExcliblePlanilla,
                        AguinaldoMes1,
                        Aplica2aguinaldo,
                        AplicaRetroactivos,
                        AplicaPrima,
                        EnviarBoletaPago,
                        Indemnizacion,
                        PorcentajeCentroCosto,
                        CuentaBancaria,
                        AplicaAFP,
                        NroAFP,
                        Jubilado,
                        AportaAFP,
                        AplicaCajaSalud,
                        NroAsegurado,
                        Discapacidad,
                        RequiereApruebeVacaciones,
                        ValorLunes,
                        ValorMartes,
                        ValorMiercoles,
                        ValorJueves,
                        ValorViernes,
                        ValorSabado,
                        ValorDomingo,
                        CodigoAsistencia,
                        DiasporMes,
                        ControlarAsistencia,
                        BonoExtra,
                        BonoExtraNocturna,
                        HorasParaHorasExtras,
                        HorasPorDia,
                        DescuentoPorFalta,
                        DescuentoPorAtraso,
                        Dominicales,
                        TrabajaDomingo,
                        HorasPlanillas,
                        Unidad,
                        Sucursal,
                        Cargo,
                        Clasificacionlaboral,
                        TipoContrato,
                        InformacionContable,
                        CentroCosto,
                        FormaPago,
                        TipoCuenta,
                        Banco,
                        AdministracionPensiones,
                        CajaSalud,
                        FormacionPrincial,
                        Sexo
                    )
                VALUES (
                         '{Ci}',
                         '{Nombre1}',
                         '{Nombre2}',
                         '{Nombre3}',
                         '{ApellidoPaterno}',
                         '{ApellidoMaterno}',
                         '{ApellidoCasado}',
                         '{FechaNacimiento.ToString("yyyy-MM-dd")}',
                         '{VencimientoDocumento.ToString("yyyy-MM-dd")}',
                         '{VencimientoLicConducir.ToString("yyyy-MM-dd")}',
                         '{LugarNacimiento}',
                         '{LicenciaConducir}',
                         '{TelefonoFijo}',
                         '{Celular}',
                         '{TelefonoFijoTrabajo}',
                         '{ContactoEmegencia}',
                         '{TelefonoEmergencia}',
                         '{ViviendaPropia}',
                         '{VehiculoPropio}',
                         '{TipoSangre}',
                         '{FactorSangre}',
                         '{Dirrecion}',
                         '{Email}',
                         '{TipoDocumento}',
                         '{Nacionalidad}',
                         '{Departamento}',
                         '{EstadoCivil}',
                         '{ConyugeNombreCompleto}',
                         '{ConyugeLugarNacimiento}',
                         '{ConyugeFechaNacimiento.ToString("yyyy-MM-dd")}',
                         '{CodigoColaborador}',
                         '{FechaIngreso.ToString("yyyy-MM-dd")}',
                         '{FechaIngresoVacaciones.ToString("yyyy-MM-dd")}',
                         '{FechaIngresoVacacionesAnt.ToString("yyyy-MM-dd")}',
                         '{FechaIngresoBonoAntiguedad.ToString("yyyy-MM-dd")}',
                         '{Oficina}',
                         '{ModohaberBasico}',
                         '{HaberBasico}',
                         '{ModoQuincena}',
                         '{HaberQuincena}',
                         '{TelefonoLaboral}',
                         '{CelularLaboral}',
                         '{DirrecionLaboral}',
                         '{EmailLaboral}',
                         '{MotivoContrato}',
                         '{ModoContrato}',
                         '{FechaFinalizacion.ToString("yyyy-MM-dd")}',
                         '{FechaRatificacion.ToString("yyyy-MM-dd")}',
                         '{ExcliblePlanilla}',
                         '{AguinaldoMes1}',
                         '{Aplica2aguinaldo}',
                         '{AplicaRetroactivos}',
                         '{AplicaPrima}',
                         '{EnviarBoletaPago}',
                         '{Indemnizacion}',
                         '{PorcentajeCentroCosto}',
                         '{CuentaBancaria}',
                         '{AplicaAFP}',
                         '{NroAFP}',
                         '{Jubilado}',
                         '{AportaAFP}',
                         '{AplicaCajaSalud}',
                         '{NroAsegurado}',
                         '{Discapacidad}',
                         '{RequiereApruebeVacaciones}',
                         '{ValorLunes}',
                         '{ValorMartes}',
                         '{ValorMiercoles}',
                         '{ValorJueves}',
                         '{ValorViernes}',
                         '{ValorSabado}',
                         '{ValorDomingo}',
                         '{CodigoAsistencia}',
                         '{DiasporMes}',
                         '{ControlarAsistencia}',
                         '{BonoExtra}',
                         '{BonoExtraNocturna}',
                         '{HorasParaHorasExtras}',
                         '{HorasPorDia}',
                         '{DescuentoPorFalta}',
                         '{DescuentoPorAtraso}',
                         '{Dominicales}',
                         '{TrabajaDomingo}',
                         '{HorasPlanillas}',
                         '{Unidad}',
                         '{Sucursal}',
                         '{Cargo}',
                         '{Clasificacionlaboral}',
                         '{TipoContrato}',
                         '{InformacionContable}',
                         '{CentroCosto}',
                         '{FormaPago}',
                         '{TipoCuenta}',
                         '{Banco}',
                         '{AdministracionPensiones}',
                         '{CajaSalud}',
                         '{FormacionPrincial}',
                         '{Sexo}'
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
                c.ci as NombreOficina,
                sucursal.NombreSucursal,
                contrato.NombreModContrato as ModoContrato,
                tipoContrato.NombreTipoContrato as TipoContrato
            FROM hhrrcolaborador as c
                inner JOIN hhrrcargo as cargo on cargo.id = c.Cargo
                INNER JOIN hhrrunidad as unidad on unidad.id = c.Unidad
                INNER JOIN hhrrsucursal as sucursal on sucursal.id = c.Sucursal
                INNER JOIN hhrrmodcontrato as contrato on contrato.id = c.ModoContrato
                INNER JOIN hhrrtipocontrato as tipoContrato on tipoContrato.id=c.TipoContrato
            ";
        }
        public string ObtenerColaboradorContrato(int id)
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
                c.HaberBasico,
                c.HaberQuincena,
                c.ModohaberBasico,
                c.ModoQuincena,
                c.Clasificacionlaboral,
                c.MotivoContrato,
                c.FechaIngreso,
                c.FechaRatificacion,
                c.FechaFinalizacion,
                c.Aplica2aguinaldo,
                c.AguinaldoMes1,
                sucursal.NombreSucursal,
                c.ModoContrato,
                c.TipoContrato
            FROM hhrrcolaborador as c
                inner JOIN hhrrcargo as cargo on cargo.id = c.Cargo
                INNER JOIN hhrrunidad as unidad on unidad.id = c.Unidad
                INNER JOIN hhrrsucursal as sucursal on sucursal.id = c.Sucursal
            WHERE
                c.id='{id}'
            ";
        }
        public string ModificarColaboradorContrato(
            int id,
            DateTime FechaIngreso,
            int ModohaberBasico,
            decimal HaberBasico,
            int ModoQuincena,
            int ModoContrato,
            int TipoContrato,
            decimal HaberQuincena,
            string MotivoContrato,
            DateTime? FechaFinalizacion,
            DateTime FechaRatificacion,
            int AguinaldoMes1,
            int Aplica2aguinaldo
            )
        {
            string validarNull = FechaFinalizacion == null ? "null" : ($"'{FechaFinalizacion?.ToString("yyyy-MM-dd")}'");
            return @$"
                update 
                    hhrrcolaborador 
                set 
                    FechaIngreso = '{FechaIngreso.ToString("yyyy-MM-dd")}',
                    ModohaberBasico = '{ModohaberBasico}',
                    HaberBasico = '{HaberBasico}',
                    ModoQuincena = '{ModoQuincena}',
                    ModoContrato = '{ModoContrato}',
                    TipoContrato = '{TipoContrato}',
                    HaberQuincena = '{HaberQuincena}',
                    MotivoContrato = '{MotivoContrato}',
                    FechaFinalizacion = {validarNull},
                    FechaRatificacion = '{FechaRatificacion.ToString("yyyy-MM-dd")}',
                    AguinaldoMes1 = '{AguinaldoMes1}',
                    Aplica2aguinaldo = '{Aplica2aguinaldo}'
                    where 
                    Id = '{id}';
            ";
        }
    }
}