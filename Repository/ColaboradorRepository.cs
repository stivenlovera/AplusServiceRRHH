using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Context;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Entities.DBAplusEmpresas.Contrato;
using AplusServiceRRHH.Querys;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace AplusServiceRRHH.Repository
{
    public class ColaboradorRepository
    {
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly ILogger<ColaboradorRepository> _logger;
        private readonly ColaboradorQuery _colaboradorQuery;

        public ColaboradorRepository(
            DbMysqlServerContext DbMysqlServerContext,
            ILogger<ColaboradorRepository> logger,
            ColaboradorQuery colaboradorQuery
        )
        {
            this._dbMysqlServerContext = DbMysqlServerContext;
            this._logger = logger;
            this._colaboradorQuery = colaboradorQuery;
        }
        public async Task<List<HHRRColaborador>> ObtenerColaborador()
        {
            this._logger.LogWarning($"ColaboradorRepository/ObtenerColaborador(): Inizialize...");
            var sql = this._colaboradorQuery.ObtenerColaborador();
            var resultado = await this._dbMysqlServerContext.HHRRColaborador.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"ColaboradorRepository/ObtenerColaborador SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"ColaboradorRepository/ObtenerColaborador: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<HHRRColaborador> ObtenerColaboradorId(int id)
        {
            this._logger.LogWarning($"ColaboradorRepository/ObtenerColaboradorId({id}): Inizialize...");
            var sql = this._colaboradorQuery.ObtenerColaboradorId(id);
            var data = await this._dbMysqlServerContext.HHRRColaborador.FromSqlRaw(sql).ToListAsync();
            var resultado = data.FirstOrDefault();
            if (resultado != null)
            {
                this._logger.LogWarning($"ColaboradorRepository/ObtenerColaboradorId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"ColaboradorRepository/ObtenerColaboradorId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
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
            int HHRRSexoId
        )
        {
            this._logger.LogWarning($"ColaboradorRepository/CrearColaboradorId(): Inizialize...");
            var sql = this._colaboradorQuery.GuardarColaborador(
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
                HHRRSexoId
            );
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado == 1)
            {
                this._logger.LogWarning($"ColaboradorRepository/CrearColaboradorId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"ColaboradorRepository/CrearColaboradorId: Message => 'No existe pudo registrar' CONSULT => {sql}");
                throw new Exception("No se registro");
            }
        }
        public async Task<List<HHRRColaborador>> ModificarColaborador(string NombreColaborador, int id)
        {
            this._logger.LogWarning($"ColaboradorRepository/UpdateColaborador(): Inizialize...");
            var sql = this._colaboradorQuery.ModificarColaborador(NombreColaborador, id);
            var resultado = await this._dbMysqlServerContext.HHRRColaborador.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"ColaboradorRepository/ModificarColaborador SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"ColaboradorRepository/ModificarColaborador: Message => 'No puso modificar' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<HHRRColaborador>> EliminarColaborador(int id)
        {
            this._logger.LogWarning($"ColaboradorRepository/EliminarColaborador(): Inizialize...");
            var sql = this._colaboradorQuery.EliminarColaborador(id);
            var resultado = await this._dbMysqlServerContext.HHRRColaborador.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"ColaboradorRepository/EliminarColaborador SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"ColaboradorRepository/EliminarColaborador: Message => 'No existe Usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<List<ColaboradorDataTable>> DatatableColaborador()
        {
            this._logger.LogWarning($"ColaboradorRepository/DatatableColaborador(): Inizialize...");
            var sql = this._colaboradorQuery.DatatableColaborador();
            var resultado = await this._dbMysqlServerContext.ColaboradorDataTable.FromSqlRaw(sql).ToListAsync();
            this._logger.LogWarning($"ColaboradorRepository/DatatableColaborador SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
            return resultado;
        }

        public async Task<ContratoColaborador> EditarContratoColaborador(int id)
        {
            this._logger.LogWarning($"ColaboradorRepository/ModicarContratoColaborador({id}): Inizialize...");
            var sql = this._colaboradorQuery.ObtenerColaboradorContrato(id);
            var data = await this._dbMysqlServerContext.ContratoColaborador.FromSqlRaw(sql).ToListAsync();
            var resultado = data.FirstOrDefault();
            if (resultado != null)
            {
                this._logger.LogWarning($"ColaboradorRepository/ObtenerColaboradorId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"ColaboradorRepository/ObtenerColaboradorId: Message => 'No existe Tipo Documento Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<bool> ModicarContratoColaborador(
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
            this._logger.LogWarning($"ColaboradorRepository/ModicarContratoColaborador({id}): Inizialize...");
            var sql = this._colaboradorQuery.ModificarColaboradorContrato(
                id,
                FechaIngreso,
                ModohaberBasico,
                HaberBasico,
                ModoQuincena,
                ModoContrato,
                TipoContrato,
                HaberQuincena,
                MotivoContrato,
                FechaFinalizacion,
                FechaRatificacion,
                AguinaldoMes1,
                Aplica2aguinaldo
            );
            this._logger.LogWarning($"{sql}");
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado == 1)
            {
                this._logger.LogWarning($"ColaboradorRepository/ModicarContratoColaborador SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"ColaboradorRepository/ModicarContratoColaborador: Message => 'o se pudo  moificar contrato' CONSULT => {sql}");
                throw new Exception("No se pudo  moificar contrato");
            }
        }
    }
}