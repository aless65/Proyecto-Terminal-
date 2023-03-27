using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Terminal.WebUI.Models
{
    public class TerminalesViewModel
    {
        [Display(Name = "Id")]
        public int term_ID { get; set; }

        [Display(Name = "Id Municipio")]
        public string muni_ID { get; set; }

        [Display(Name = "Municipio")]
        public string muni_Descripcion { get; set; }

        [Display(Name = "Id Departamento")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        public string dept_ID { get; set; }

        [Display(Name = " Departamento")]
        public string dept_Descripcion { get; set; }

        [Display(Name = " Nombre de la terminal")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        public string term_Nombre { get; set; }

        [Display(Name = "Direccion Exacta")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        public string term_DireccionExacta { get; set; }

        [Display(Name = " Cantidad de Transporte")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]

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
