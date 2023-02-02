using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Entities.DBAplusEmpresas
{
    public class HHRRSucursal
    {
        [Key]
        public int Id { get; set; }
        public string NombreSucursal { get; set; }
        public string Direccion { get; set; }
    }
}