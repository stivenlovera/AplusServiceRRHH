using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Dtos;
using AplusServiceRRHH.Dtos.CargoDto;
using AplusServiceRRHH.Modules;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AplusServiceRRHH.Controllers
{
    [ApiController]
    [Route("api/cargo")]
    public class CargoController : ControllerBase
    {
        private readonly ILogger<CargoController> _logger;
        private readonly CargoModule _cargoModule;

        public CargoController(
            ILogger<CargoController> logger,
            CargoModule cargoModule
        )
        {
            this._logger = logger;
            this._cargoModule = cargoModule;
        }
        [HttpGet]
        public async Task<Response> ObtenerCargo()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerCargo() Inizialize ...");
            try
            {
                var Cargo = await this._cargoModule.ObtenerCargo();
                return new Response
                {
                    Status = 1,
                    Message = "load datatable cargo",
                    data = Cargo
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
        [HttpPost("store")]
        public async Task<Response> GuardarCargo([FromBody] CargoDto cargoDto)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} GuardarCargo({JsonConvert.SerializeObject(cargoDto, Formatting.Indented)}) Inizialize ...");
            try
            {
                var insert = await this._cargoModule.CrearCargo(cargoDto.nombreCargo);
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
        public async Task<Response> ObtenerOneCargo(int id)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerOneCargo() Inizialize ...");
            try
            {
                var editar= await this._cargoModule.ObtenerCargoId(id);
                return new Response
                {
                    Status = 1,
                    Message = "Mostrando un cargo",
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
                this._logger.LogError($"ObtenerOneCargo() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPut("update/{id:int}")]
        public async Task<Response> UpdateCargo(int id, CargoDto cargoDto)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} UpdateCargo() Inizialize ...");
            try
            {
                var update = await this._cargoModule.ModificarCargoId(cargoDto.nombreCargo, id);
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
                this._logger.LogError($"UpdateCargo() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpDelete("delete/{id:int}")]
        public async Task<Response> DeleteCargo(int id)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} DeleteCargo() Inizialize ...");
            try
            {
                var delete = await this._cargoModule.EliminarCargoId(id);
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
                this._logger.LogError($"DeleteCargo() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
    }
}