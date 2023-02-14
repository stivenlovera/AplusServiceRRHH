using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Dtos.ColaboradorDto
{
    public class UpdateContratoColaboradorDto
    {
        public int id { get; set; }
        public string codigoColaborador { get; set; }
        public int modalidadContrato { get; set; }
        public int clasificacionLaboral { get; set; }
        public decimal haberbasico { get; set; }
        public decimal haberQuincena { get; set; }
        public int modoHaberBasico { get; set; }
        public int modoQuincena { get; set; }
        public int tipoContrato { get; set; }
        public string motivoContrato { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime? fechaFinalizacion { get; set; }
        public DateTime fechaRatificacion { get; set; }
        public int aplicaAguinaldo { get; set; }
        public int aplicaSegundoAguinaldo { get; set; }
    }
}

