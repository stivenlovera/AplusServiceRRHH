using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class CentroCostoQuery
    {
        public string ObtenerCentroCosto()
        {
            return @$"
               SELECT id,`NombreCentroCosto` FROM hhrrcentrocosto;
            ";
        }
        public string ObtenerCentroCostoId(int id)
        {
            return @$"
               SELECT id,`NombreCentroCosto` FROM hhrrcentrocosto WHERE id='{id}';
            ";
        }
        public string GuardarCentroCosto(string NombreCentroCosto)
        {
            return @$"
                insert into 
                hhrrcentrocosto (
                    `NombreCentroCosto`
                )
                values
                ( 
                    '{NombreCentroCosto}'
                );
            ";
        }
        public string ModificarCentroCosto(string NombreCentroCosto, int id)
        {
            return @$"
            update 
                hhrrcentrocosto 
            set 
                NombreCentroCosto = '{NombreCentroCosto}'
            where 
                id = '{id}';
            ";
        }
        public string EliminarCentroCosto(int id)
        {
            return @$"
                delete from 
                    hhrrcentrocosto 
                where 
                    id = '{id}';
            ";
        }
    }
}