using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Entities.DBAplusEmpresas.Usuarios
{
    public class Login
    {
        [Key]
        public int id { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public int HHRRcolaboradorId { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Nombre3 { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string ApellidoCasado { get; set; }
    }
}