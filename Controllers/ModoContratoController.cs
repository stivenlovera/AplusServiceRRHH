using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Dtos;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AplusServiceRRHH.Controllers
{
    [ApiController]
    [Route("api/modo-contrato")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ModoContratoController : ControllerBase
    {
        private readonly ILogger<ModoContratoController> _logger;

        public ModoContratoController(
            ILogger<ModoContratoController> logger
        )
        {
            this._logger = logger;
        }
        [HttpGet]
        public Response ObtenerModoContrato()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerModoContrato() Inizialize ...");
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
                this._logger.LogError($"ObtenerModoContrato() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPost]
        public Response GuardarModoContrato()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerModoContrato() Inizialize ...");
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
                this._logger.LogError($"ObtenerModoContrato() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpGet("{id:int}")]
        public Response ObtenerOneModoContrato()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerModoContrato() Inizialize ...");
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
                this._logger.LogError($"ObtenerModoContrato() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPut("{id:int}")]
        public Response UpdateModoContrato()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerModoContrato() Inizialize ...");
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
                this._logger.LogError($"ObtenerModoContrato() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpDelete("{id:int}")]
        public Response DeleteModoContrato()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerModoContrato() Inizialize ...");
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
                this._logger.LogError($"ObtenerModoContrato() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
    }
}