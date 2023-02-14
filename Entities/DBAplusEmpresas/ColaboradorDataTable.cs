using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Entities.DBAplusEmpresas
{
    public class ColaboradorDataTable
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
        public string NombreSucursal { get; set; }
        public string NombreOficina { get; set; }
        public string ModoContrato { get; set; }
        public string TipoContrato { get; set; }
    }
}