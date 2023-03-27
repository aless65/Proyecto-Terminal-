using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Terminal.WebUI.Models
{
    public class MunicipioViewModel
    {

        public string dept_ID { get; set; }
        public string muni_ID { get; set; }
        public string muni_Descripcion { get; set; }
        public int? muni_Estado { get; set; }
        public int? muni_UsuarioCreador { get; set; }
        public DateTime? muni_FechaCreacion { get; set; }
        public int? muni_UsuarioModificador { get; set; }
        public DateTime? muni_FechaModificacion { get; set; }

    }
}
