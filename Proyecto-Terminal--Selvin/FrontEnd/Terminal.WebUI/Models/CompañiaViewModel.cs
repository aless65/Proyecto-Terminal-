using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Terminal.WebUI.Models
{
    public class CompañiaViewModel
    {
        public int comp_ID { get; set; }
        public string comp_Nombre { get; set; }
        public string muni_ID { get; set; }
        public string comp_Direccion { get; set; }
        public int? comp_Estado { get; set; }
        public int? comp_UsuarioCreador { get; set; }
        public DateTime? comp_FechaCreacion { get; set; }
        public int? comp_UsuarioModificador { get; set; }
        public DateTime? comp_FechaModificacion { get; set; }
    }
}
