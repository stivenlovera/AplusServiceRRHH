using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Entities.DBAplusEmpresas
{
    public class HHRRColaborador
    {
        public int Id { get; set; }
        public string Ci { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Nombre3 { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string ApellidoCasado { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime VencimientoDocumento { get; set; }
        public DateTime VencimientoLicConducir { get; set; }
        public string LugarNacimiento { get; set; }
        public string LicenciaConducir { get; set; }
        public string TelefonoFijo { get; set; }
        public string Celular { get; set; }
        public string TelefonoFijoTrabajo { get; set; }
        public string ContactoEmegencia { get; set; }
        public string TelefonoEmergencia { get; set; }
        public string TipoSangre { get; set; }
        public string FactorSangre { get; set; }
        public string Dirrecion { get; set; }
        public string Email { get; set; }
        public string TipoDocumento { get; set; }
        public string Nacionalidad { get; set; }
        public string Departamento { get; set; }
        public string EstadoCivil { get; set; }
        public string ConyugeNombreCompleto { get; set; }
        public string ConyugeLugarNacimiento { get; set; }
        public string ConyugeFechaNacimiento { get; set; }
        public string CodigoColaborador { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaIngresoVacaciones { get; set; }
        public DateTime FechaIngresoVacacionesAnt { get; set; }
        public DateTime FechaIngresoBonoAntiguedad { get; set; }
        public int Oficina { get; set; }
        public int ModohaberBasico { get; set; }
        public int HaberBasico { get; set; }
        public int ModoQuincena { get; set; }
        public int HaberQuincena { get; set; }
        public int TelefonoLaboral { get; set; }
        public string CelularLaboral { get; set; }
        public int DirrecionLaboral { get; set; }
        public string EmailLaboral { get; set; }
        public string MotivoContrato { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        public DateTime FechaRatificacion { get; set; }
        public int ExcliblePlanilla { get; set; }
        public int AguinaldoMes1 { get; set; }
        public int Aplica2aguinaldo { get; set; }
        public int AplicaRetroactivos { get; set; }
        public int AplicaPrima { get; set; }
        public int EnviarBoletaPago { get; set; }
        public int Indemnizacion { get; set; }
        public int PorcentajeCentroCosto { get; set; }
        public int CuentaBancaria { get; set; }
        public int AplicaAFP { get; set; }
        public int NroAFP { get; set; }
        public int Jubilado { get; set; }
        public int AportaAFP { get; set; }
        public int AplicaCajaSalud { get; set; }
        public string NroAsegurado { get; set; }
        public int Discapacidad { get; set; }
        public int RequiereApruebeVacaciones { get; set; }
        public decimal ValorLunes { get; set; }
        public decimal ValorMartes { get; set; }
        public decimal ValorMiercoles { get; set; }
        public decimal ValorJueves { get; set; }
        public decimal ValorViernes { get; set; }
        public decimal ValorSabado { get; set; }
        public decimal ValorDomingo { get; set; }
        public int CodigoAsistencia { get; set; }
        public int DiasporMes { get; set; }
        public int ControlarAsistencia { get; set; }
        public int BonoExtra { get; set; }
        public int BonoExtraNocturna { get; set; }
        public int HorasParaHorasExtras { get; set; }
        public int HorasPorDia { get; set; }
        public int DescuentoPorFalta { get; set; }
        public int DescuentoPorAtraso { get; set; }
        public int Dominicales { get; set; }
        public int TrabajaDomingo { get; set; }
        public int HorasPlanillas { get; set; }
        public int Unidad { get; set; }
        public int Sucursal { get; set; }
        public int Cargo { get; set; }
        public int Clasificacionlaboral { get; set; }
        public int TipoContrato { get; set; }
        public int InformacionContable { get; set; }
        public int CentroCosto { get; set; }
        public int FormaPago { get; set; }
        public int TipoCuenta { get; set; }
        public int Banco { get; set; }
        public int AdministracionPensiones { get; set; }
        public int CajaSalud { get; set; }
        public int FormacionPrincial { get; set; }
        public int Sexo { get; set; }
    }
}