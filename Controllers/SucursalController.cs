using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Dtos;
using AplusServiceRRHH.Dtos.SucursalDto;
using AplusServiceRRHH.Modules;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AplusServiceRRHH.Controllers
{
    [ApiController]
    [Route("api/sucursal")]
    public class SucursalController : ControllerBase
    {
        private readonly ILogger<SucursalController> _logger;
        private readonly SucursalModule _sucursalModule;

        public SucursalController(
            ILogger<SucursalController> logger,
            SucursalModule sucursalModule
        )
        {
            this._logger = logger;
            this._sucursalModule = sucursalModule;
        }
        [HttpGet("data-table")]
        public async Task<Response> ObtenerSucursal()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerSucursal() Inizialize ...");
            try
            {
                var obtener = await this._sucursalModule.ObtenerSucursal();
                var resultado = new Response
                {
                    Status = 1,
                    Message = "Mostrar lista de sucursales",
                    data = obtener
                };
                this._logger.LogWarning($"ObtenerSucursal SUCCESS => {JsonConvert.SerializeObject(obtener, Formatting.Indented)}");
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
                this._logger.LogError($"ObtenerSucursal() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPost("store")]
        public async Task<Response> GuardarSucursal(SucursalDto sucursalDto)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerSucursal({JsonConvert.SerializeObject(sucursalDto, Formatting.Indented)}) Inizialize ...");
            try
            {
                var obtener = await this._sucursalModule.CrearSucursal(sucursalDto.nombreSucursal, sucursalDto.direccion);
                var resultado = new Response
                {
                    Status = 1,
                    Message = "Sucursal registrado correctamente",
                    data = obtener
                };
                this._logger.LogWarning($"GuardarSucursal SUCCESS => {JsonConvert.SerializeObject(obtener, Formatting.Indented)}");
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
                this._logger.LogError($"ObtenerSucursal() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpGet("edit/{id:int}")]
        public async Task<Response> ObtenerOneSucursal(int id)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerOneSucursal({id}) Inizialize ...");
            try
            {
                var obtener = await this._sucursalModule.ObtenerSucursalId(id);
                var resultado = new Response
                {
                    Status = 1,
                    Message = "Mostrando una sucursal",
                    data = obtener
                };
                this._logger.LogWarning($"ObtenerOneSucursal SUCCESS => {JsonConvert.SerializeObject(obtener, Formatting.Indented)}");
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
                this._logger.LogError($"ObtenerOneSucursal() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPut("update/{id:int}")]
        public async Task<Response> UpdateSucursal(int id, SucursalDto sucursalDto)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} UpdateSucursal({id},{JsonConvert.SerializeObject(sucursalDto, Formatting.Indented)}) Inizialize ...");
            try
            {
                var obtener = await this._sucursalModule.ModificarSucursalId(sucursalDto.nombreSucursal, sucursalDto.direccion, id);
                var resultado = new Response
                {
                    Status = 1,
                    Message = "Modificado correctamente",
                    data = obtener
                };
                this._logger.LogWarning($"UpdateSucursal SUCCESS => {JsonConvert.SerializeObject(obtener, Formatting.Indented)}");
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
                this._logger.LogError($"UpdateSucursal() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpDelete("delete/{id:int}")]
        public async Task<Response> DeleteSucursal(int id)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} DeleteSucursal({id}) Inizialize ...");
            try
            {
                var obtener = await this._sucursalModule.EliminarSucursalId(id);
                var resultado = new Response
                {
                    Status = 1,
                    Message = "Eliminado correctamente",
                    data = obtener
                };
                this._logger.LogWarning($"UpdateSucursal SUCCESS => {JsonConvert.SerializeObject(obtener, Formatting.Indented)}");
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
                this._logger.LogError($"DeleteSucursal() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
    }
}