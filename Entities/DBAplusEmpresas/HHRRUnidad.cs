using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Entities.DBAplusEmpresas
{
    public class HHRRUnidad
    {
        [Key]
        public int Id { get; set; }
        public string NombreUnidad { get; set; }
    }
}