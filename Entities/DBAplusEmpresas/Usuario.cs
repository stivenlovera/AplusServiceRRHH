
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Entities.DBAplusEmpresas
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string User { get; set; }
        public string nombreCompleto { get; set; }
        public int Estado { get; set; }
        public string Password { get; set; }
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }
}