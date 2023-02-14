using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Dtos;
using AplusServiceRRHH.Dtos.OficinaDto;
using AplusServiceRRHH.Modules;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AplusServiceRRHH.Controllers
{
    [ApiController]
    [Route("api/oficina")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class OficinaController : ControllerBase
    {
        private readonly ILogger<OficinaController> _logger;
        private readonly OficinaModule _oficinaModule;
        private readonly SucursalModule _sucursalModule;

        public OficinaController(
            ILogger<OficinaController> logger,
            OficinaModule oficinaModule,
            SucursalModule sucursalModule
        )
        {
            this._logger = logger;
            this._oficinaModule = oficinaModule;
            this._sucursalModule = sucursalModule;
        }
        [HttpGet("data-table")]
        public async Task<Response> ObtenerOficina()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerOficina() Inizialize ...");
            try
            {
                var obtener = await this._oficinaModule.ObtenerOficina();
                var resultado = new Response
                {
                    Status = 1,
                    Message = "Obtener Oficina",
                    data = obtener
                };
                this._logger.LogWarning($"ObtenerOficina SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
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
                this._logger.LogError($"ObtenerOficina() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpGet("create")]
        public async Task<Response> CreateOficina()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} CreateOficina() Inizialize ...");
            try
            {
                var obtenerSucursal = await this._sucursalModule.ObtenerSucursal();
                var resultado = new Response
                {
                    Status = 1,
                    Message = "Crear Oficina",
                    data = obtenerSucursal
                };
                this._logger.LogWarning($"CreateOficina SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
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
                this._logger.LogError($"CreateOficina() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPost("store")]
        public async Task<Response> GuardarOficina(OficinaDto oficinaDto)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerOficina({JsonConvert.SerializeObject(oficinaDto, Formatting.Indented)}) Inizialize ...");
            try
            {
                var obtener = await this._oficinaModule.CrearOficina(oficinaDto.nombreOficina,oficinaDto.sucursalId);
                var resultado = new Response
                {
                    Status = 1,
                    Message = "Guardado correctamente",
                    data = obtener
                };
                this._logger.LogWarning($"ObtenerOficina SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
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
                this._logger.LogError($"ObtenerOficina() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpGet("edit/{id:int}")]
        public async Task<Response> ObtenerOneOficina(int id)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerOneOficina() Inizialize ...");
            try
            {
                var obtener = await this._oficinaModule.ObtenerOficinaId(id);
                var resultado = new Response
                {
                    Status = 1,
                    Message = "Obtener una Oficina",
                    data = obtener
                };
                this._logger.LogWarning($"ObtenerOneOficina SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
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
                this._logger.LogError($"ObtenerOneOficina() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPut("update/{id:int}")]
        public async Task<Response> UpdateOficina(int id, OficinaDto oficinaDto)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} UpdateOficina({JsonConvert.SerializeObject(oficinaDto, Formatting.Indented)}) Inizialize ...");
            try
            {
                var obtener = await this._oficinaModule.ModificarOficinaId(oficinaDto.nombreOficina, oficinaDto.sucursalId, id);
                var resultado = new Response
                {
                    Status = 1,
                    Message = "Modificado correctamente",
                    data = obtener
                };
                this._logger.LogWarning($"UpdateOficina SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
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
                this._logger.LogError($"UpdateOficina() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpDelete("delete/{id:int}")]
        public async Task<Response> DeleteOficina(int id)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} DeleteOficina({id}) Inizialize ...");
            try
            {
                var eliminar = await this._oficinaModule.EliminarOficinaId(id);
                var resultado = new Response
                {
                    Status = 1,
                    Message = "Eliminado correctamente",
                    data = null
                };
                this._logger.LogWarning($"DeleteOficina SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
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
                this._logger.LogError($"DeleteOficina() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
    }
}