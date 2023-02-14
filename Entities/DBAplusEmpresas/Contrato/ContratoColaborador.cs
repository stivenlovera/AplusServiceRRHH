using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Entities.DBAplusEmpresas.Contrato
{
    public class ContratoColaborador
    {
        [Key]
        public int Id { get; set; }
        public string Ci { get; set; }
        public string CodigoColaborador { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Nombre3 { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string ApellidoCasado { get; set; }
        public string NombreCargo { get; set; }
        public string NombreUnidad { get; set; }
        public int HaberBasico { get; set; }
        public int HaberQuincena { get; set; }
        public int ModohaberBasico { get; set; }
        public int ModoQuincena { get; set; }
        public int Clasificacionlaboral { get; set; }
        public string MotivoContrato { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaRatificacion { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public int Aplica2aguinaldo { get; set; }
        public int AguinaldoMes1 { get; set; }
        public string NombreSucursal { get; set; }
        public int ModoContrato { get; set; }
        public int TipoContrato { get; set; }
    }
}