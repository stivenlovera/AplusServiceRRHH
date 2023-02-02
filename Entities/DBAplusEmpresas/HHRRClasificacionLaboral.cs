using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Entities.DBAplusEmpresas
{
    public class HHRRClasificacionLaboral
    {
        [Key]
        public int Id { get; set; }
        public string NombreClasificacionLaboral { get; set; }
    }
}