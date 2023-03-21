using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Entities.DBAplusEmpresas.Usuarios
{
    public class HHRRUsuario
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public int HHRRcolaboradorId { get; set; }
    }
}