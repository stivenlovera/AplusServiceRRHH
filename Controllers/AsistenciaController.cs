using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Dtos;
using AplusServiceRRHH.Dtos.Asistencia;
using AplusServiceRRHH.Modules;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AplusServiceRRHH.Controllers
{
    [ApiController]
    [Route("api/asistencia")]
    public class AsistenciaController : ControllerBase
    {
        private readonly ILogger<AsistenciaController> _logger;
        private readonly AsistenciaModule _asistenciaModule;

        public AsistenciaController(
            ILogger<AsistenciaController> logger,
            AsistenciaModule asistenciaModule
        )
        {
            this._logger = logger;
            this._asistenciaModule = asistenciaModule;
        }
         [HttpGet]
        public async Task<Response> ObtenerAsistencia()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerAsistencia() Inizialize ...");
            try
            {
                var asistencia = await this._asistenciaModule.DataTableAsistencia();
                
                return new Response
                {
                    Status = 1,
                    Message = "load datatable asistencia",
                    data = asistencia
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
                this._logger.LogError($"ObtenerAsistencia() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPost("store")]
        public async Task<Response> GuardarAsistencia([FromBody] AsistenciaDto asistenciaDto)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} GuardarAsistencia({JsonConvert.SerializeObject(asistenciaDto, Formatting.Indented)}) Inizialize ...");
            try
            {
                var insert = await this._asistenciaModule.CrearAsistencia(
                    asistenciaDto.fechaRegistro,
                    asistenciaDto.fechaEntrada,
                    asistenciaDto.fechaSalida,
                    asistenciaDto.horaEntrada,
                    asistenciaDto.horaSalida,
                    asistenciaDto.nota,
                    asistenciaDto.HHRRColaboradorId
                );
                return new Response
                {
                    Status = 1,
                    Message = "Registrado Correctamente",
                    data = new
                    {

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
                this._logger.LogError($"ObtenerCargo() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpGet("edit/{id:int}")]
        public async Task<Response> ObtenerOneAsistencia(int id)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerOneAsistencia({id}) Inizialize ...");
            try
            {
                var editar= await this._asistenciaModule.ObtenerAsistenciaId(id);
                return new Response
                {
                    Status = 1,
                    Message = "Mostrando un asistencia",
                    data = editar
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
                this._logger.LogError($"ObtenerOneAsistencia() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPut("update/{id:int}")]
        public async Task<Response> UpdateAsistencia(int id, [FromBody] AsistenciaDto asistenciaDto)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} UpdateAsistencia({JsonConvert.SerializeObject(asistenciaDto, Formatting.Indented)}) Inizialize ...");
            try
            {
                var update = await this._asistenciaModule.ModificarAsistenciaId(
                    asistenciaDto.id,
                    asistenciaDto.fechaRegistro,
                    asistenciaDto.fechaEntrada,
                    asistenciaDto.fechaSalida,
                    asistenciaDto.horaEntrada,
                    asistenciaDto.horaSalida,
                    asistenciaDto.nota,
                    asistenciaDto.HHRRColaboradorId
                );
                return new Response
                {
                    Status = 1,
                    Message = "Modificado corretamente",
                    data = new
                    {

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
                this._logger.LogError($"UpdateAsistencia() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpDelete("delete/{id:int}")]
        public async Task<Response> DeleteAsistencia(int id)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} DeleteAsistencia({id}) Inizialize ...");
            try
            {
                var delete = await this._asistenciaModule.EliminarAsistenciaId(id);
                return new Response
                {
                    Status = 1,
                    Message = "cargo eliminado correctamente",
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
                this._logger.LogError($"DeleteAsistencia() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
    }
}