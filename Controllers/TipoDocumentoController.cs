using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Dtos;
using AplusServiceRRHH.Dtos.TipoDocumento;
using AplusServiceRRHH.Modules;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AplusServiceRRHH.Controllers
{
    [ApiController]
    [Route("api/tipo-documento")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class TipoDocumentoController : ControllerBase
    {
        private readonly ILogger<TipoDocumentoController> _logger;
        private readonly TipoDocumentoModule _tipoDocumentoModule;

        public TipoDocumentoController(
              ILogger<TipoDocumentoController> logger,
              TipoDocumentoModule TipoDocumentoModule
        )
        {
            this._logger = logger;
            this._tipoDocumentoModule = TipoDocumentoModule;
        }

        [HttpGet] // api/Auth/login
        public async Task<Response> MostrarTodo()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} MostrarTodo() Inizialize ...");
            try
            {
                var mostrarTodo = await this._tipoDocumentoModule.ObtenerTipoDocumento();
                var resultado = new Response
                {
                    Status = 1,
                    Message = "mostrando todo",
                    data = mostrarTodo
                };
                this._logger.LogWarning($"MostrarTodo() SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            catch (System.Exception e)
            {
                var resultado = new Response
                {
                    Status = 0,
                    Message = e.Message,
                    data = null
                };
                this._logger.LogError($"MostrarTodo() ERROR => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
        }
        [HttpGet("{id:int}")]
        public async Task<Response> MostrarUno(int id)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} MostrarTodo() Inizialize ...");
            try
            {
                var mostrarTodo = await this._tipoDocumentoModule.ObtenerTipoDocumentoId(id);
                var resultado = new Response
                {
                    Status = 1,
                    Message = "mostrando todo",
                    data = mostrarTodo
                };
                this._logger.LogWarning($"MostrarUno() SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            catch (System.Exception e)
            {
                var resultado = new Response
                {
                    Status = 0,
                    Message = e.Message,
                    data = null
                };
                this._logger.LogError($"MostrarUno() ERROR=> {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }

        }
        [HttpPost()]
        public async Task<Response> CrearUno(int id, CrearTipoDocumentoDto createTipoDocumentoDto)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} CrearUno({createTipoDocumentoDto},{JsonConvert.SerializeObject(createTipoDocumentoDto, Formatting.Indented)}) Inizialize ...");
            var mostrarTodo = await this._tipoDocumentoModule.CrearTipoDocumento(createTipoDocumentoDto.NombreTipoDocumento);
            return new Response
            {
                Status = 1,
                Message = "mostrando todo",
                data = mostrarTodo
            };
        }
        [HttpPut("{id:int}")]
        public async Task<Response> Modificar(int id, ModificarTipoDocumentoDto createTipoDocumentoDto)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} Modificar({createTipoDocumentoDto},{JsonConvert.SerializeObject(createTipoDocumentoDto, Formatting.Indented)}) Inizialize ...");
            var mostrarTodo = await this._tipoDocumentoModule.CrearTipoDocumento(createTipoDocumentoDto.NombreTipoDocumento);
            return new Response
            {
                Status = 1,
                Message = "modificado conrrectamente",
                data = mostrarTodo
            };
        }
        [HttpDelete("{id:int}")]
        public async Task<Response> Eliminar(int id)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} Eliminar({id}) Inizialize ...");
            var mostrarTodo = await this._tipoDocumentoModule.EliminarTipoDocumentoId(id);
            return new Response
            {
                Status = 1,
                Message = "mostrando todo",
                data = mostrarTodo
            };
        }
    }
}