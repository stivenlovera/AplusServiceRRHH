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
    [Route("api/formacion")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class FormacionPrincipalController : ControllerBase
    {
        private readonly ILogger<FormacionPrincipalController> _logger;

        public FormacionPrincipalController(
            ILogger<FormacionPrincipalController> logger
        )
        {
            this._logger = logger;
        }
        [HttpGet]
        public Response ObtenerFormacionPrincipal()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerFormacionPrincipal() Inizialize ...");
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
                this._logger.LogError($"ObtenerFormacionPrincipal() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPost]
        public Response GuardarFormacionPrincipal()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerFormacionPrincipal() Inizialize ...");
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
                this._logger.LogError($"ObtenerFormacionPrincipal() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpGet("{id:int}")]
        public Response ObtenerOneFormacionPrincipal()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerFormacionPrincipal() Inizialize ...");
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
                this._logger.LogError($"ObtenerFormacionPrincipal() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPut("{id:int}")]
        public Response UpdateFormacionPrincipal()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerFormacionPrincipal() Inizialize ...");
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
                this._logger.LogError($"ObtenerFormacionPrincipal() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpDelete("{id:int}")]
        public Response DeleteFormacionPrincipal()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerFormacionPrincipal() Inizialize ...");
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
                this._logger.LogError($"ObtenerFormacionPrincipal() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
    }
}