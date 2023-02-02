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
    [Route("api/oficina")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class OficinaController : ControllerBase
    {
        private readonly ILogger<OficinaController> _logger;

        public OficinaController(
            ILogger<OficinaController> logger
        )
        {
            this._logger = logger;
        }
        [HttpGet]
        public Response ObtenerOficina()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerOficina() Inizialize ...");
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
                this._logger.LogError($"ObtenerOficina() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPost]
        public Response GuardarOficina()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerOficina() Inizialize ...");
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
                this._logger.LogError($"ObtenerOficina() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpGet("{id:int}")]
        public Response ObtenerOneOficina()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerOficina() Inizialize ...");
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
                this._logger.LogError($"ObtenerOficina() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPut("{id:int}")]
        public Response UpdateOficina()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerOficina() Inizialize ...");
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
                this._logger.LogError($"ObtenerOficina() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpDelete("{id:int}")]
        public Response DeleteOficina()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerOficina() Inizialize ...");
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
                this._logger.LogError($"ObtenerOficina() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
    }
}