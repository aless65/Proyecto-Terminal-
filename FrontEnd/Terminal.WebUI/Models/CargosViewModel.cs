using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Terminal.WebUI.Models
{
    public class CargosViewModel
    {
        public int carg_ID { get; set; }
        public string carg_Nombre { get; set; }
        public int? carg_Estado { get; set; }
        public int? carg_UsuarioCreador { get; set; }
        public string carg_UsuarioCreador_Nombre { get; set; }
        public DateTime? carg_FechaCreacion { get; set; }
        public int? carg_UsuarioModificador { get; set; }
        public string carg_UsuarioModificador_Nombre { get; set; }
        public DateTime? carg_FechaModificacion { get; set; }
    }
}
