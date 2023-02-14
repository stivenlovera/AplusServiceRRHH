using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Entities.DBAplusEmpresas.Asistencia
{
    public class AsistenciaDataTable
    {
        public int id { get; set; }
        public string CodigoColaborador { get; set; }
        public DateTime fechaRegistro { get; set; }
        public DateTime fechaEntrada { get; set; }
        public DateTime fechaSalida { get; set; }
        public TimeSpan horaEntrada { get; set; }
        public TimeSpan horaSalida { get; set; }
        public string nota { get; set; }
        public int HHRRColaboradorId { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Nombre3 { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string ApellidoCasado { get; set; }
        public string NombreCargo { get; set; }
    }
}