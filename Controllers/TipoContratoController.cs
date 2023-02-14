using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Dtos;
using AplusServiceRRHH.Dtos.TipoContratoDto;
using AplusServiceRRHH.Repository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AplusServiceRRHH.Controllers
{
    [ApiController]
    [Route("api/tipo-contrato")]
    public class TipoContratoController : ControllerBase
    {
        private readonly ILogger<TipoContratoController> _logger;
        private readonly TipoContratoRepository _tipoContratoRepository;

        public TipoContratoController(
            ILogger<TipoContratoController> logger,
            TipoContratoRepository tipoContratoRepository
        )
        {
            this._logger = logger;
            this._tipoContratoRepository = tipoContratoRepository;
        }
        [HttpGet]
        public async Task<Response> ObtenerTipoContrato()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerTipoContrato() Inizialize ...");
            try
            {
                var tiposcontratos = await this._tipoContratoRepository.ObtenerTipoContratos();
                return new Response
                {
                    Status = 1,
                    Message = "Lista tipo contrato",
                    data = tiposcontratos
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
                this._logger.LogError($"ObtenerTipoContrato() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPost("store")]
        public async Task<Response> GuardarTipoContrato(TipoContratoDto tipoContratoDto)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerTipoContrato({JsonConvert.SerializeObject(tipoContratoDto, Formatting.Indented)}) Inizialize ...");
            try
            {
                var insert = await this._tipoContratoRepository.CrearTipoContrato(tipoContratoDto.nombreModalidad);
                return new Response
                {
                    Status = 1,
                    Message = "Registrado correctamente",
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
                this._logger.LogError($"ObtenerTipoContrato() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpGet("edit/{id:int}")]
        public async Task<Response> ObtenerOneTipoContrato(int id)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerTipoContrato({id}) Inizialize ...");
            var obtener = await this._tipoContratoRepository.ObtenerTipoContratoId(id);
            try
            {
                return new Response
                {
                    Status = 1,
                    Message = "Mostrar un tipo contrato",
                    data = obtener
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
                this._logger.LogError($"ObtenerTipoContrato() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPut("update/{id:int}")]
        public async Task<Response> UpdateTipoContrato(int id, TipoContratoDto tipoContratoDto)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} UpdateTipoContrato({id},{JsonConvert.SerializeObject(tipoContratoDto, Formatting.Indented)}) Inizialize ...");
            try
            {
                var update = await this._tipoContratoRepository.ModificarTipoContrato(tipoContratoDto.nombreModalidad, id);
                return new Response
                {
                    Status = 1,
                    Message = "Modificado correctamente",
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
                this._logger.LogError($"ObtenerTipoContrato() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpDelete("delete/{id:int}")]
        public async Task<Response> DeleteTipoContrato(int id)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerTipoContrato({id}) Inizialize ...");
            try
            {
                var eliminar = await this._tipoContratoRepository.EliminarTipoContrato(id);
                return new Response
                {
                    Status = 1,
                    Message = "Eliminado correctamente",
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
                this._logger.LogError($"ObtenerTipoContrato() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
    }
}