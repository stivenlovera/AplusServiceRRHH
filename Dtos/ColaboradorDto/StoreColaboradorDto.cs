using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Dtos.ColaboradorDto
{
    public class StoreColaboradorDto
    {
        public string ci { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Nombre3 { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string ApellidoCasado { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime VencimientoDocumento { get; set; }
        public DateTime VencimientoLicConducir { get; set; }
        public string LugarNacimiento { get; set; }
        public string LicenciaConducir { get; set; }
        public string TelefonoFijo { get; set; }
        public string Celular { get; set; }
        public string TelefonoFijoTrabajo { get; set; }
        public string ContactoEmegencia { get; set; }
        public string TelefonoEmergencia { get; set; }
        public string ViviendaPropia { get; set; }
        public string VehiculoPropio { get; set; }
        public string TipoSangre { get; set; }
        public string FactorSangre { get; set; }
        public string Dirrecion { get; set; }
        public string Email { get; set; }
        public int TipoDocumento { get; set; }
        public int Nacionalidad { get; set; }
        public int Departamento { get; set; }
        public int EstadoCivil { get; set; }
    }
}