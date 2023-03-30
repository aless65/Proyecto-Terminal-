using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Terminal.WebUI.Models
{
    public class EmpleadoViewModel
    {
        public int empl_ID { get; set; }
        public string empl_PrimerNombre { get; set; }
        public string empl_SegundoNombre { get; set; }
        public string empl_PrimerApellido { get; set; }
        public string empl_SegundoApellido { get; set; }
        public string empl_NombreCompleto { get; set; }
        public string empl_DNI { get; set; }
        public DateTime? empl_FechaNacimiento { get; set; }
        public string empl_Sexo { get; set; }
        public string empl_Telefono { get; set; }
        public int? carg_ID { get; set; }
        public int? estciv_ID { get; set; }
        public string muni_ID { get; set; }
        public int? empl_Estado { get; set; }
        public int? empl_UsuarioCreador { get; set; }
        public DateTime? empl_FechaCreacion { get; set; }
        public int? empl_UsuarioModificador { get; set; }
        public DateTime? empl_FechaModificacion { get; set; }

    }
}
