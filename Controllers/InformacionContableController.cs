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
    [Route("api/informacion-contable")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class InformacionContableController : ControllerBase
    {
        private readonly ILogger<InformacionContableController> _logger;

        public InformacionContableController(
            ILogger<InformacionContableController> logger
        )
        {
            this._logger = logger;
        }
        [HttpGet]
        public Response ObtenerInformacionContable()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerInformacionContable() Inizialize ...");
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
                this._logger.LogError($"ObtenerInformacionContable() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPost]
        public Response GuardarInformacionContable()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerInformacionContable() Inizialize ...");
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
                this._logger.LogError($"ObtenerInformacionContable() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpGet("{id:int}")]
        public Response ObtenerOneInformacionContable()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerInformacionContable() Inizialize ...");
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
                this._logger.LogError($"ObtenerInformacionContable() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPut("{id:int}")]
        public Response UpdateInformacionContable()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerInformacionContable() Inizialize ...");
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
                this._logger.LogError($"ObtenerInformacionContable() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpDelete("{id:int}")]
        public Response DeleteInformacionContable()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerInformacionContable() Inizialize ...");
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
                this._logger.LogError($"ObtenerInformacionContable() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
    }
}