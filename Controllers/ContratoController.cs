using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Dtos;
using AplusServiceRRHH.Dtos.ColaboradorDto;
using AplusServiceRRHH.Models;
using AplusServiceRRHH.Modules;
using AplusServiceRRHH.Utils;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AplusServiceRRHH.Controllers
{
    [ApiController]
    [Route("api/contrato")]
    public class ContratoController : ControllerBase
    {
        private readonly ILogger<CargoController> _logger;
        private readonly ContratoModule _contratoModule;
        private readonly ColaboradorModule _colaboradorModule;
        private readonly ClasificacionLaboralModule _clasificacionLaboralModule;
        private readonly ModContratoModule _modContratoModule;
        private readonly TipoContratoModule _tipoContratoModule;

        public ContratoController(
            ILogger<CargoController> logger,
            ContratoModule contratoModule,
            ColaboradorModule colaboradorModule,
            ClasificacionLaboralModule clasificacionLaboralModule,
            ModContratoModule modContratoModule,
            TipoContratoModule tipoContratoModule
        )
        {
            this._logger = logger;
            this._contratoModule = contratoModule;
            this._colaboradorModule = colaboradorModule;
            this._clasificacionLaboralModule = clasificacionLaboralModule;
            this._modContratoModule = modContratoModule;
            this._tipoContratoModule = tipoContratoModule;
        }
        [HttpGet("create")]
        public async Task<Response> CreateContratoColaborador()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} EditContratoColaborador() Inizialize ...");
            try
            {
                var resultado = new Response
                {
                    Status = 1,
                    Message = "Obtener data contrato",
                    data = new
                    {
                        tipoContrato = await this._tipoContratoModule.ObtenerTipoContrato(),
                        clasificacion = await this._clasificacionLaboralModule.ObtenerClasificacionLaboral(),
                        modalidadContrato = await this._modContratoModule.ObtenerModContrato(),
                    }
                };
                this._logger.LogWarning($"EditContratoColaborador SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            catch (System.Exception e)
            {
                var result = new Response
                {
                    Status = 0,
                    Message = e.Message,
                    data = null
                };
                this._logger.LogError($"CreateContratoColaborador() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpGet("edit/{id:int}")]
        public async Task<Response> EditContratoColaborador(int id)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} EditContratoColaborador({id}) Inizialize ...");
            try
            {
                var obtener = await this._contratoModule.EditarContratosColaborador(id);
                var resultado = new Response
                {
                    Status = 1,
                    Message = "Obtener colaborador contrato",
                    data = new
                    {
                        id = obtener.Id,
                        ci = obtener.Ci,
                        nombreCompleto = $"{obtener.Nombre1} {obtener.Nombre2} {obtener.Nombre3} {obtener.ApellidoPaterno} {obtener.ApellidoMaterno} {obtener.ApellidoCasado}",
                        cargo = obtener.NombreCargo,
                        codigoColaborador = obtener.CodigoColaborador,
                        sucursal = obtener.NombreSucursal,
                        oficina = obtener.NombreUnidad,
                        haberBasico = obtener.HaberBasico,
                        modoQuincena = obtener.ModoQuincena,
                        haberQuincena = obtener.HaberQuincena,
                        clasificacionLaboral = obtener.Clasificacionlaboral,
                        motivoContrato = obtener.MotivoContrato,
                        fechaInicio = obtener.FechaIngreso,
                        fechaFinalizacion = obtener.FechaFinalizacion,
                        fechaRatificacion = obtener.FechaRatificacion,
                        aplicaAguinaldo = obtener.AguinaldoMes1,
                        aplicaSegundoAguinaldo = obtener.Aplica2aguinaldo,
                        modoHaberBasico = obtener.ModohaberBasico,
                        tipoContrato = obtener.TipoContrato,
                        modalidadContrato = obtener.ModoContrato,
                    }
                };
                this._logger.LogWarning($"EditContratoColaborador SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            catch (System.Exception e)
            {
                var result = new Response
                {
                    Status = 0,
                    Message = e.Message,
                    data = null
                };
                this._logger.LogError($"EditContratoColaborador() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPut("update/{id:int}")]
        public async Task<Response> UpdateContratoColaborador(int id, [FromBody] UpdateContratoColaboradorDto updateContratoColaboradorDto)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} UpdateContratoColaborador({id},{JsonConvert.SerializeObject(updateContratoColaboradorDto, Formatting.Indented)}) Inizialize ...");
            try
            {
                var obtener = await this._contratoModule.UpdateContratosColaborador(
                    id,
                    updateContratoColaboradorDto.fechaInicio,
                    updateContratoColaboradorDto.modoHaberBasico,
                    updateContratoColaboradorDto.haberbasico,
                    updateContratoColaboradorDto.modoQuincena,
                    updateContratoColaboradorDto.modalidadContrato,
                    updateContratoColaboradorDto.tipoContrato,
                    updateContratoColaboradorDto.haberQuincena,
                    updateContratoColaboradorDto.motivoContrato,
                    updateContratoColaboradorDto.fechaFinalizacion,
                    updateContratoColaboradorDto.fechaRatificacion,
                    updateContratoColaboradorDto.aplicaAguinaldo,
                    updateContratoColaboradorDto.aplicaSegundoAguinaldo
                );
                var resultado = new Response
                {
                    Status = 1,
                    Message = "Modificado correctamente",
                    data = null
                };
                this._logger.LogWarning($"EditContratoColaborador SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            catch (System.Exception e)
            {
                var result = new Response
                {
                    Status = 0,
                    Message = e.Message,
                    data = null
                };
                this._logger.LogError($"UpdateContratoColaborador() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpGet("generar-preview-contrato/{id:int}")]
        public FileStreamResult GenerarPreviewContrato(int id)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} UpdateContratoColaborador({id}) Inizialize ...");
            try
            {
                var documento = this._contratoModule.GenerarContrato(id);
                this._logger.LogWarning($"EditContratoColaborador SUCCESS => Documento generado correctamente");
                var fileVacio = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                var contentType = @"application/pdf";
                var stream = new MemoryStream(fileVacio);
                this._logger.LogError($"{Request.Method}{Request.Path} GenerarContrato() errir al proposito");
                return File(stream, contentType);
            }
            catch (System.Exception e)
            {
                var fileVacio = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                var contentType = @"application/pdf";
                var stream = new MemoryStream(fileVacio);
                this._logger.LogError($"{Request.Method}{Request.Path} vistaPreviaContratoAPI() Salida : ERROR => {e}");
                return File(stream, contentType);
            }
        }
        [HttpGet("generar-descarga-contrato/{id:int}")]
        public async Task<FileContentResult> GenerarContrato(int id)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} GenerarContrato({id}) Inizialize ...");
            try
            {
                var documento = await this._contratoModule.GenerarContrato(id);
                this._logger.LogWarning($"GenerarContrato SUCCESS => Documento generado correctamente");
                var contentType = @"application/pdf";
                var stream = new MemoryStream(documento.File);
                return new FileContentResult(documento.File, contentType)
                {
                    FileDownloadName = $"contrato {documento.nombreDocumento}.pdf"
                };
            }
            catch (System.Exception e)
            {
                var fileVacio = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
                var contentType = @"application/pdf";
                var stream = new MemoryStream(fileVacio);
                this._logger.LogError($"{Request.Method}{Request.Path} vistaPreviaContratoAPI() Salida : ERROR => {e}");
                return new FileContentResult(fileVacio, contentType)
                {
                    FileDownloadName = "error.pdf"
                };
            }
        }
    }
}