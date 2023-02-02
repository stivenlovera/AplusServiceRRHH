using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplusServiceRRHH.Querys
{
    public class TipoDocumentoQuery
    {
        public string ObtenerTipoDocumento()
        {
            return @$"
                SELECT 
                    id,
                    TipoDocumento 
                FROM 
                    hhrrtipodocumento;
            ";
        }
        public string ObtenerTipoDocumentoId(int id)
        {
            return @$"
                SELECT 
                    id,
                    TipoDocumento 
                FROM 
                    hhrrtipodocumento;
                WHERE
                    id='{id}'
            ";
        }
        public string GuardarTipoDocumento(string nombreTipo)
        {
            return @$"
            INSERT INTO
                `HHRRTipoDocumento`(`TipoDocumento`)
            VALUES ('{nombreTipo}');
            ";
        }
        public string ModificarTipoDocumento(string nombreTipo, int id)
        {
            return @$"
                update hhrrtipodocumento
                set
                    TipoDocumento = '{nombreTipo}'
                where id = '{id}';
            ";
        }
        public string EliminarTipoDocumento(int id)
        {
            return @$"
                delete from 
                    hhrrtipodocumento 
                where 
                    id = '{id}';
            ";
        }
    }
}