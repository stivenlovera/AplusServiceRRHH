using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Dtos;
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
                var Cargo= await this._cargoModule.ObtenerCargo();
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
        [HttpPost]
        public Response GuardarCargo()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerCargo() Inizialize ...");
            try
            {
                return new Response
                {
                    Status = 1,
                    Message = "cargando formulario",
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
        [HttpGet("{id:int}")]
        public Response ObtenerOneCargo()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerCargo() Inizialize ...");
            try
            {
                return new Response
                {
                    Status = 1,
                    Message = "cargando formulario",
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
        [HttpPut("{id:int}")]
        public Response UpdateCargo()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerCargo() Inizialize ...");
            try
            {
                return new Response
                {
                    Status = 1,
                    Message = "cargando formulario",
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
        [HttpDelete("{id:int}")]
        public Response DeleteCargo()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerCargo() Inizialize ...");
            try
            {
                return new Response
                {
                    Status = 1,
                    Message = "cargando formulario",
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
    }
}