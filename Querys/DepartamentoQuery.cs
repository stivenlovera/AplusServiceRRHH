using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class DepartamentoQuery
    {
        public string ObtenerDepartamento()
        {
            return @$"
                SELECT id,`NombreDepartamento`,`HHRRPaisId` FROM hhrrdepartamento;
            ";
        }
        public string ObtenerDepartamentoId(int id)
        {
            return @$"
               SELECT id,`NombreDepartamento`,`HHRRPaisId` FROM hhrrdepartamento WHERE id='{id}';
            ";
        }
        public string GuardarDepartamento(string NombreDepartamento, int HHRRPaisId)
        {
            return @$"
                insert into 
                    hhrrdepartamento (
                    `NombreDepartamento`, 
                    `HHRRPaisId`
                    )
                values
                    ( 
                    '{NombreDepartamento}', 
                    '{HHRRPaisId}'
                    );
            ";
        }
        public string ModificarDepartamento(string NombreDepartamento, int HHRRPaisId, int id)
        {
            return @$"
                update 
                    hhrrdepartamento 
                set 
                    NombreDepartamento = '{NombreDepartamento}',
                    HHRRPaisId = '{HHRRPaisId}'
                where 
                id = '{id}';
            ";
        }
        public string EliminarDepartamento(int id)
        {
            return @$"
                    delete from 
                        hhrrdepartamento 
                    where 
                        id = '{id}';
            ";
        }
    }
}