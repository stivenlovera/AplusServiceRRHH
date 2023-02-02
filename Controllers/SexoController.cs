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
    [Route("api/sexo")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class SexoController : ControllerBase
    {
        private readonly ILogger<SexoController> _logger;

        public SexoController(
            ILogger<SexoController> logger
        )
        {
            this._logger = logger;
        }
        [HttpGet]
        public Response ObtenerSexo()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerSexo() Inizialize ...");
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
                this._logger.LogError($"ObtenerSexo() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPost]
        public Response GuardarSexo()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerSexo() Inizialize ...");
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
                this._logger.LogError($"ObtenerSexo() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpGet("{id:int}")]
        public Response ObtenerOneSexo()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerSexo() Inizialize ...");
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
                this._logger.LogError($"ObtenerSexo() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPut("{id:int}")]
        public Response UpdateSexo()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerSexo() Inizialize ...");
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
                this._logger.LogError($"ObtenerSexo() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpDelete("{id:int}")]
        public Response DeleteSexo()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerSexo() Inizialize ...");
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
                this._logger.LogError($"ObtenerSexo() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
    }
}