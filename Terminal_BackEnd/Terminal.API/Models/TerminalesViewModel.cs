using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Terminal.API.Models
{
    public class TerminalesViewModel
    {
        public int term_ID { get; set; }
        public string muni_ID { get; set; }
        public string muni_Descripcion { get; set; }
        public string dept_ID { get; set; }
        public string dept_Descripcion { get; set; }
        public string term_Nombre { get; set; }
        public string term_DireccionExacta { get; set; }
        public int? term_CantidadTransportes { get; set; }
        public int? term_Estado { get; set; }
        public int? term_UsuarioCreador { get; set; }
        public string term_UsuarioCreador_Nombre { get; set; }
        public DateTime? term_FechaCreacion { get; set; }
        public int? term_UsuarioModificador { get; set; }
        public string term_UsuarioModificador_Nombre { get; set; }
        public DateTime? term_FechaModificacion { get; set; }
    }
}
