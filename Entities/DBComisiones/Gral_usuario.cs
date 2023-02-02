using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AplusServiceRRHH.Entities.DBComisiones
{
    [Keyless]
    public class Gral_usuario
    {
        public string usua_id { get; set; }
        public string usua_password { get; set; }
        public int usua_estado_id { get; set; }
        public string usua_nombre { get; set; }
        public int usua_pers_id { get; set; }
        public int usua_grupo_usua_id { get; set; }
        public int usua_empr_id { get; set; }
    }
}