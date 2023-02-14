using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Models
{
    public class ContratoDefault
    {
        public bool Preview { get; set; }
        public string NombreEmpresa { get; set; }
        public string ImagenEmpresa { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string ModalidadContrato { get; set; }
        public string haberBasico { get; set; }
        public string HaberQuincena { get; set; }
        public string MotivoContratacion { get; set; }
        public string Cargo { get; set; }
    }
}