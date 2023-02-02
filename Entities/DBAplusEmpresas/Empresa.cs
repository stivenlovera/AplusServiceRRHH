using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using Microsoft.EntityFrameworkCore;

namespace AplusServiceRRHH.Entities.DBAplusEmpresas
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Dirrecion { get; set; }
        public string Representante { get; set; }
        public DateTime fechaIngreso { get; set; }
        public List<ImagenEmpresa> ImagenEmpresa { get; set; }
        public List<Contacto> Contactos { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
}