using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Dtos.Asistencia
{
    public class AsistenciaDto
    {
        public int id { get; set; }
        public DateTime fechaRegistro { get; set; }
        public DateTime? fechaEntrada { get; set; }
        public DateTime? fechaSalida { get; set; }
        public DateTime? horaEntrada { get; set; }
        public DateTime? horaSalida { get; set; }
        public string nota { get; set; }
        public int HHRRColaboradorId { get; set; }

    }
}