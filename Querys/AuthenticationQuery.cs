using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class AuthenticationQuery
    {
        public string LoginQuery(string Usuario, string Password)
        {
            return $@"
                SELECT usuario.nombreCompleto, usuario.EmpresaId, empresa.id, empresa.Nombre FROM usuario INNER JOIN empresa on empresa.Id=usuario.EmpresaId WHERE User='{Usuario}' and Password='{Password}' and Estado='1' 
            "; 
        }
    }
}