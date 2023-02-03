using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Dtos;
using AplusServiceRRHH.Dtos.ColaboradorDto;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Modules;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AplusServiceRRHH.Controllers
{
    [ApiController]
    [Route("api/colaborador")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ColaboradorController : ControllerBase
    {
        private readonly ILogger<AuthenticationController> _logger;
        private readonly TipoDocumentoModule _tipoDocumentoModule;
        private readonly DepartamentoModule _departamentoModule;
        private readonly PaisModule _paisModule;
        private readonly EstadoCivilModule _estadoCivilModule;
        private readonly SucursalModule _sucursalModule;
        private readonly UnidadModule _unidadModule;
        private readonly CargoModule _cargoModule;
        private readonly ClasificacionLaboralModule _clasificacionLaboralModule;
        private readonly ModContratoModule _modContratoModule;
        private readonly TipoContratoModule _tipoContratoModule;
        private readonly InformacionContableModule _informacionContableModule;
        private readonly CentroCostoModule _centroCostoModule;
        private readonly FormaPagoModule _formaPagoModule;
        private readonly TipoCuentaModule _tipoCuentaModule;
        private readonly BancoModule _bancoModule;
        private readonly AdministracionPensionesModule _administracionPensionesModule;
        private readonly CajaSaludModule _cajaSaludModule;
        private readonly FormacionPrincipalModule _formacionPrincipalModule;
        private readonly SexoModule _sexoModule;
        private readonly ColaboradorModule _colaboradorModule;

        public ColaboradorController(
            ILogger<AuthenticationController> logger,
            TipoDocumentoModule TipoDocumentoModule,
            DepartamentoModule departamentoModule,
            PaisModule paisModule,
            EstadoCivilModule estadoCivilModule,
            SucursalModule sucursalModule,
            UnidadModule unidadModule,
            CargoModule cargoModule,
            ClasificacionLaboralModule clasificacionLaboralModule,
            ModContratoModule modContratoModule,
            TipoContratoModule tipoContratoModule,
            InformacionContableModule informacionContableModule,
            CentroCostoModule centroCostoModule,
            FormaPagoModule formaPagoModule,
            TipoCuentaModule tipoCuentaModule,
            BancoModule bancoModule,
            AdministracionPensionesModule administracionPensionesModule,
            CajaSaludModule cajaSaludModule,
            FormacionPrincipalModule formacionPrincipalModule,
            SexoModule sexoModule,
            ColaboradorModule colaboradorModule
        )
        {
            this._logger = logger;
            this._tipoDocumentoModule = TipoDocumentoModule;
            this._departamentoModule = departamentoModule;
            this._paisModule = paisModule;
            this._estadoCivilModule = estadoCivilModule;
            this._sucursalModule = sucursalModule;
            this._unidadModule = unidadModule;
            this._cargoModule = cargoModule;
            this._clasificacionLaboralModule = clasificacionLaboralModule;
            this._modContratoModule = modContratoModule;
            this._tipoContratoModule = tipoContratoModule;
            this._informacionContableModule = informacionContableModule;
            this._centroCostoModule = centroCostoModule;
            this._formaPagoModule = formaPagoModule;
            this._tipoCuentaModule = tipoCuentaModule;
            this._bancoModule = bancoModule;
            this._administracionPensionesModule = administracionPensionesModule;
            this._cajaSaludModule = cajaSaludModule;
            this._formacionPrincipalModule = formacionPrincipalModule;
            this._sexoModule = sexoModule;
            this._colaboradorModule = colaboradorModule;
        }
        [HttpGet("create")] // api/Auth/login
        public async Task<Response> Create()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} Create() Inizialize ...");
            try
            {
                var tipoDocumento = await this._tipoDocumentoModule.ObtenerTipoDocumento();
                var pais = await this._paisModule.ObtenerPais();
                var departamento = await this._departamentoModule.ObtenerDepartamentos();
                var estadoCivil = await this._estadoCivilModule.ObtenerEstadoCivil();
                var unidad = await this._unidadModule.ObtenerUnidad();
                var sucursal = await this._sucursalModule.ObtenerSucursal();
                var cargo = await this._cargoModule.ObtenerCargo();
                var clasificacionLaboral = await this._clasificacionLaboralModule.ObtenerClasificacionLaboral();
                var modalidadContrato = await this._modContratoModule.ObtenerModContrato();
                var tipoContrato = await this._tipoContratoModule.ObtenerTipoContrato();
                var informacionContable = await this._informacionContableModule.ObtenerInformacionContable();
                var centroCosto = await this._centroCostoModule.ObtenerCentroCosto();
                var formaPago = await this._formaPagoModule.ObtenerFormaPago();
                var tipoCuenta = await this._tipoCuentaModule.ObtenerTipoCuenta();
                var banco = await this._bancoModule.ObtenerBanco();
                var administracionPensiones = await this._administracionPensionesModule.ObtenerAdministracionPesion();
                var cajaSalud = await this._cajaSaludModule.ObtenerCajaSalud();
                var formacionPrincial = await this._formacionPrincipalModule.ObtenerFormacionPrincipal();
                var sexo = await this._sexoModule.ObtenerSexo();
                return new Response
                {
                    Status = 1,
                    Message = "cargando formulario",
                    data = new
                    {
                        TipoDocumento = tipoDocumento,
                        Pais = pais,
                        Departamento = departamento,
                        EstadoCivil = estadoCivil,
                        Unidad = unidad,
                        Sucursal = sucursal,
                        Cargo = cargo,
                        Clasificacionlaboral = clasificacionLaboral,
                        ModalidadContrato = modalidadContrato,
                        TipoContrato = tipoContrato,
                        InformacionContable = informacionContable,
                        CentroCosto = centroCosto,
                        FormaPago = formaPago,
                        TipoCuenta = tipoCuenta,
                        Banco = banco,
                        AdministracionPensiones = administracionPensiones,
                        CajaSalud = cajaSalud,
                        FormacionPrincial = formacionPrincial,
                        Sexo = sexo
                    }
                };
            }
            catch (System.Exception e)
            {
                var result = new Response
                {
                    Status = 0,
                    Message = e.Message,
                    data = null
                };
                this._logger.LogError($"Login() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPost("Store")] // api/Auth/login
        public async Task<Response> Store([FromBody] StoreColaboradorDto storeColaboradorDto)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} Create({JsonConvert.SerializeObject(storeColaboradorDto, Formatting.Indented)}) Inizialize ...");
            try
            {
                this._logger.LogWarning($"{storeColaboradorDto.VencimientoDocumento.ToString("dd/MM/yyyy")}");
                var storeColaborador = await this._colaboradorModule.CrearColaborador(
                    storeColaboradorDto.ci,
                    storeColaboradorDto.Nombre1,
                    storeColaboradorDto.Nombre2,
                    storeColaboradorDto.Nombre3,
                    storeColaboradorDto.ApellidoPaterno,
                    storeColaboradorDto.ApellidoMaterno,
                    storeColaboradorDto.ApellidoCasado,
                    storeColaboradorDto.FechaNacimiento,
                    storeColaboradorDto.VencimientoDocumento,
                    storeColaboradorDto.VencimientoLicConducir,
                    storeColaboradorDto.LugarNacimiento,
                    storeColaboradorDto.LicenciaConducir,
                    storeColaboradorDto.TelefonoFijo,
                    storeColaboradorDto.Celular,
                    storeColaboradorDto.TelefonoFijoTrabajo,
                    storeColaboradorDto.ContactoEmegencia,
                    storeColaboradorDto.TelefonoEmergencia,
                    storeColaboradorDto.ViviendaPropia,
                    storeColaboradorDto.VehiculoPropio,
                    storeColaboradorDto.TipoSangre,
                    storeColaboradorDto.FactorSangre,
                    storeColaboradorDto.Dirrecion,
                    storeColaboradorDto.Email,
                    storeColaboradorDto.TipoDocumento,
                    storeColaboradorDto.Nacionalidad,
                    storeColaboradorDto.Departamento,
                    storeColaboradorDto.EstadoCivil,
                    storeColaboradorDto.ConyugeNombreCompleto,
                    storeColaboradorDto.ConyugeLugarNacimiento,
                    storeColaboradorDto.ConyugeFechaNacimiento,
                    storeColaboradorDto.CodigoColaborador,
                    storeColaboradorDto.FechaIngreso,
                    storeColaboradorDto.FechaIngresoVacaciones,
                    storeColaboradorDto.FechaIngresoVacacionesAnt,
                    storeColaboradorDto.FechaIngresoBonoAntiguedad,
                    storeColaboradorDto.Oficina,
                    storeColaboradorDto.ModohaberBasico,
                    storeColaboradorDto.HaberBasico,
                    storeColaboradorDto.ModoQuincena,
                    storeColaboradorDto.HaberQuincena,
                    storeColaboradorDto.TelefonoLaboral,
                    storeColaboradorDto.CelularLaboral,
                    storeColaboradorDto.DirrecionLaboral,
                    storeColaboradorDto.EmailLaboral,
                    storeColaboradorDto.MotivoContrato,
                    storeColaboradorDto.FechaFinalizacion,
                    storeColaboradorDto.FechaRatificacion,
                    storeColaboradorDto.ExcliblePlanilla,
                    storeColaboradorDto.AguinaldoMes1,
                    storeColaboradorDto.Aplica2aguinaldo,
                    storeColaboradorDto.AplicaRetroactivos,
                    storeColaboradorDto.AplicaPrima,
                    storeColaboradorDto.EnviarBoletaPago,
                    storeColaboradorDto.Indemnizacion,
                    storeColaboradorDto.PorcentajeCentroCosto,
                    storeColaboradorDto.CuentaBancaria,
                    storeColaboradorDto.AplicaAFP,
                    storeColaboradorDto.NroAFP,
                    storeColaboradorDto.Jubilado,
                    storeColaboradorDto.AportaAFP,
                    storeColaboradorDto.AplicaCajaSalud,
                    storeColaboradorDto.NroAsegurado,
                    storeColaboradorDto.Discapacidad,
                    storeColaboradorDto.RequiereApruebeVacaciones,
                    storeColaboradorDto.ValorLunes,
                    storeColaboradorDto.ValorMartes,
                    storeColaboradorDto.ValorMiercoles,
                    storeColaboradorDto.ValorJueves,
                    storeColaboradorDto.ValorViernes,
                    storeColaboradorDto.ValorSabado,
                    storeColaboradorDto.ValorDomingo,
                    storeColaboradorDto.CodigoAsistencia,
                    storeColaboradorDto.DiasporMes,
                    storeColaboradorDto.ControlarAsistencia,
                    storeColaboradorDto.BonoExtra,
                    storeColaboradorDto.BonoExtraNocturna,
                    storeColaboradorDto.HorasParaHorasExtras,
                    storeColaboradorDto.HorasPorDia,
                    storeColaboradorDto.DescuentoPorFalta,
                    storeColaboradorDto.DescuentoPorAtraso,
                    storeColaboradorDto.Dominicales,
                    storeColaboradorDto.TrabajaDomingo,
                    storeColaboradorDto.HorasPlanillas,
                    storeColaboradorDto.Unidad,
                    storeColaboradorDto.Sucursal,
                    storeColaboradorDto.Cargo,
                    storeColaboradorDto.Clasificacionlaboral,
                    storeColaboradorDto.TipoContrato,
                    storeColaboradorDto.InformacionContable,
                    storeColaboradorDto.CentroCosto,
                    storeColaboradorDto.FormaPago,
                    storeColaboradorDto.TipoCuenta,
                    storeColaboradorDto.Banco,
                    storeColaboradorDto.AdministracionPensiones,
                    storeColaboradorDto.CajaSalud,
                    storeColaboradorDto.FormacionPrincial,
                    storeColaboradorDto.Sexo
                );
                
                return new Response
                {
                    Status = 1,
                    Message = "registrado correctamente",
                    data = null
                };
            }
            catch (System.Exception e)
            {
                var result = new Response
                {
                    Status = 0,
                    Message = e.Message,
                    data = null
                };
                this._logger.LogError($"Store() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpGet("data-table")] // api/Auth/login
        public async Task<Response> DataTable()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} Create() Inizialize ...");

            try
            {
                var colaboradores = await this._colaboradorModule.ObtenerColaborador();
                var resultado = new List<object>();
                foreach (var value in colaboradores)
                {
                    resultado.Add(new
                    {
                        id = value.Id,
                        ci = value.Ci,
                        codColaborador = value.CodigoColaborador,
                        nombreCompleto = $"{value.Nombre1} {value.Nombre2} {value.Nombre3} {value.ApellidoPaterno} {value.ApellidoMaterno} {value.ApellidoCasado}",
                        cargo = value.NombreCargo,
                        sucursal = value.NombreSucursal,
                        oficina = value.NombreUnidad,
                    });
                }
                return new Response
                {
                    Status = 1,
                    Message = "dataTable",
                    data = resultado
                };
            }
            catch (System.Exception e)
            {
                var result = new Response
                {
                    Status = 0,
                    Message = e.Message,
                    data = null
                };
                this._logger.LogError($"Login() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }

    }
}