using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;

namespace AplusServiceRRHH.Entities.DBAplusEmpresas
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Dirrecion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }
}