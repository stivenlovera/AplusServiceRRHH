using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Models;

namespace AplusServiceRRHH.Utils
{
    public class GenerateDocumento
    {
        private readonly RazorRendererHelper _razorRendererHelper;
        private readonly GeneratePlantilla _generatePlantilla;

        public GenerateDocumento( 
            RazorRendererHelper RazorRendererHelper,
            GeneratePlantilla generatePlantilla
        )
        {
            this._razorRendererHelper = RazorRendererHelper;
            this._generatePlantilla = generatePlantilla;
        }
        public byte[] GenerateContrato(ContratoDefault contratoDefault)
        {
            var partialName = "/Plantilla/ContratoDefault.cshtml";
            var htmlContent = this._razorRendererHelper.RenderPartialToString(partialName, contratoDefault);
            return this._generatePlantilla.GeneratePdf(htmlContent);
        }
    }
}