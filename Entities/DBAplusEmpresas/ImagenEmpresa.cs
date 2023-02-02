using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;

namespace AplusServiceRRHH.Entities.DBAplusEmpresas
{
    public class ImagenEmpresa
    {
        [Key]
        public int Id { get; set; }
        public string Path { get; set; }
        public string size { get; set; }
        public string Caption { get; set; }
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }
}