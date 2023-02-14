using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class EmpresaQuery
    {
        public string ObtenerEmpresas()
        {
            return $@"
                SELECT * FROM empresa;
            ";
        }
        public string ObtenerEmpresa(int id)
        {
            return $@"
                SELECT * FROM empresa where id='{id}';
            ";
        }
        public string ModificarEmpresa(
            int id,
            string Nombre,
            string Descripcion,
            string Dirrecion,
            string Representante,
            DateTime fechaIngreso
        )
        {
            return $@"
               update 
                    empresa 
                set 
                    Nombre = '{Nombre}',
                    Descripcion = '{Descripcion}',
                    Dirrecion = '{Dirrecion}',
                    Representante = '{Representante}',
                    fechaIngreso = '{fechaIngreso}'
                where 
                    Id = '{id}';
            ";
        }
    }
}