using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class ColaboradorModule
    {
        private readonly ILogger<ColaboradorModule> _logger;
        private readonly ColaboradorRepository _colaboradorRepository;

        public ColaboradorModule(
            ILogger<ColaboradorModule> logger,
            ColaboradorRepository colaboradorRepository
        )
        {
            this._logger = logger;
            this._colaboradorRepository = colaboradorRepository;
        }
        public async Task<List<ColaboradorDataTable>> ObtenerColaborador()
        {
            return await this._colaboradorRepository.DatatableColaborador();
        }
        public async Task<HHRRColaborador> ObtenerColaboradorId(int id)
        {
            return await this._colaboradorRepository.ObtenerColaboradorId(id);
        }
        public async Task<bool> CrearColaborador(
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
            return await this._colaboradorRepository.CrearColaborador(
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
            );
        }
        public async Task<List<HHRRColaborador>> ModificarColaboradorId(string NombreColaborador, int id)
        {
            return await this._colaboradorRepository.ModificarColaborador(NombreColaborador, id);
        }
        public async Task<List<HHRRColaborador>> EliminarColaboradorId(int id)
        {
            return await this._colaboradorRepository.EliminarColaborador(id);
        }
    }
}