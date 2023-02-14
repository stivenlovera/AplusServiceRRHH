using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Dtos;
using AplusServiceRRHH.Dtos.ModoContrato;
using AplusServiceRRHH.Modules;
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
        private readonly ModContratoModule _modContratoModule;

        public ModoContratoController(
            ILogger<ModoContratoController> logger,
            ModContratoModule modContratoModule
        )
        {
            this._logger = logger;
            this._modContratoModule = modContratoModule;
        }
        [HttpGet]
        public async Task<Response> ObtenerModoContrato()
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerModoContrato() Inizialize ...");
            try
            {
                var modalidadContratos = await this._modContratoModule.ObtenerModContrato();
                return new Response
                {
                    Status = 1,
                    Message = "Obtener modo contrato",
                    data = modalidadContratos
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
        [HttpPost("store")]
        public async Task<Response> GuardarModoContrato(ModoContratoDto modoContratoDto)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} GuardarModoContrato({JsonConvert.SerializeObject(modoContratoDto, Formatting.Indented)}) Inizialize ...");
            try
            {
                var insert = await this._modContratoModule.CrearModContrato(modoContratoDto.nombreModalidad,modoContratoDto.dias);
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
                this._logger.LogError($"GuardarModoContrato() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpGet("edit/{id:int}")]
        public async Task<Response> ObtenerOneModoContrato(int id)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} ObtenerOneModoContrato({id}) Inizialize ...");
            try
            {
                var edit = await this._modContratoModule.ObtenerModContratoId(id);
                return new Response
                {
                    Status = 1,
                    Message = "Mostrar un modo Contrato",
                    data = edit
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
                this._logger.LogError($"ObtenerOneModoContrato() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpPut("update/{id:int}")]
        public async Task<Response> UpdateModoContrato(int id, ModoContratoDto modoContratoDto)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} UpdateModoContrato({id},{JsonConvert.SerializeObject(modoContratoDto, Formatting.Indented)}) Inizialize ...");
            try
            {
                var update = await this._modContratoModule.ModificarModContrato(modoContratoDto.nombreModalidad,modoContratoDto.dias, id);
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
                this._logger.LogError($"UpdateModoContrato() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
        [HttpDelete("delete/{id:int}")]
        public async Task<Response> DeleteModoContrato(int id)
        {
            this._logger.LogWarning($"{Request.Method}{Request.Path} DeleteModoContrato({id}) Inizialize ...");
            try
            {
                var eliminar = await this._modContratoModule.EliminarModContrato(id);
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
                this._logger.LogError($"DeleteModoContrato() ERROR=> {JsonConvert.SerializeObject(result, Formatting.Indented)}");
                return result;
            }
        }
    }
}