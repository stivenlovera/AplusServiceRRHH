using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace AplusServiceRRHH.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<AsistenciaController> _logger;

        public HomeController(
             ILogger<AsistenciaController> logger
        )
        {
            this._logger = logger;
        }

        [HttpGet("tarjeta")]
        public Response Tarjetas()
        {
            Thread.Sleep(2000);
            var cards = new List<object>();
            cards.Add(
                new
                {
                    color = "0",
                    descripcion = "Total personas",
                    icon = "0",
                    monto = "2"
                }
            );
            cards.Add(
                new
                {
                    color = "0",
                    descripcion = "Total contratos",
                    icon = "0",
                    monto = "1"
                }
            );
            var response = new Response()
            {
                Status = 1,
                Message = "lista tarjetas",
                data = cards
            };
            return response;
        }
    }
}