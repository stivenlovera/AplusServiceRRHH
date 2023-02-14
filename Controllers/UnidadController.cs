using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Dtos;
using AplusServiceRRHH.Dtos.UnidadDto;
using AplusServiceRRHH.Modules;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AplusServiceRRHH.Controllers
{
    [ApiController]
    [Route("api/unidad")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class UnidadController : ControllerBase
    {
        private readonly ILogger<UnidadController> _logger;
        private readonly UnidadModule _unidadModule;

        public UnidadController(
            ILogger<UnidadController> logger,
            UnidadModule unidadModule
        )
        {
            this._logger = logger;
            this._unidadModule = unidadModule;
        }
        [HttpGet]
        public async Task<Response> ObtenerUnidad()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} Create() Inizialize ...");
            try
            {
                var unidad = await this._unidadModule.ObtenerUnidad();
                return new Response
                {
                    Status = 1,
                    Message = "load datatable",
                    data = unidad
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
                this._logger.LogError($"ObtenerUnidad() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPost("store")]
        public async Task<Response> GuardarUnidad(UnidadDto unidadDto)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerUnidad() Inizialize ...");
            try
            {
                var insert = await this._unidadModule.CrearUnidad(unidadDto.nombreUnidad);
                return new Response
                {
                    Status = 1,
                    Message = "Registrado correctamente",
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
                this._logger.LogError($"ObtenerUnidad() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpGet("edit/{id:int}")]
        public async Task<Response> ObtenerOneUnidad(int id)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerUnidad() Inizialize ...");
            try
            {
                var edit = await this._unidadModule.ObtenerUnidadId(id);

                return new Response
                {
                    Status = 1,
                    Message = "cargando formulario",
                    data = edit
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
                this._logger.LogError($"ObtenerUnidad() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPut("update/{id:int}")]
        public async Task<Response> UpdateUnidad(int id, UnidadDto unidadDto)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerUnidad() Inizialize ...");
            try
            {
                var update = await this._unidadModule.ModificarUnidadId(unidadDto.nombreUnidad, id);
                return new Response
                {
                    Status = 1,
                    Message = "Modificado Correctamente",
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
                this._logger.LogError($"ObtenerUnidad() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpDelete("delete/{id:int}")]
        public async Task<Response> DeleteUnidad(int id)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} DeleteUnidad() Inizialize ...");
            try
            {
                var eliminar=await this._unidadModule.EliminarUnidadId(id);
                return new Response
                {
                    Status = 1,
                    Message = "Eliminado Correctamente",
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
                this._logger.LogError($"DeleteUnidad() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
    }
}