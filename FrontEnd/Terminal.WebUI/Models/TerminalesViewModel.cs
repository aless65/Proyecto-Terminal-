using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Terminal.WebUI.Models
{
    public class TerminalesViewModel
    {
        [Display(Name ="Terminal")]
        public int term_ID { get; set; }


        [Display(Name = "Municipio")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        public string muni_ID { get; set; }


        [Display(Name = "Municipio")]
        public string muni_Descripcion { get; set; }
     
        
        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        public string dept_ID { get; set; }


        [Display(Name = "Departamento")]
        public string dept_Descripcion { get; set; }
        
        
        [Display(Name = "Terminal")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "No se aceptan numeros")]
        [StringLength(300)]
        public string term_Nombre { get; set; }

        
        [Display(Name = "Dirección exacta")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        [StringLength(500)]
        public string term_DireccionExacta { get; set; }

        
        [Display(Name = "Transportes")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Solo se aceptan numeros")]
        [MinLength(1, ErrorMessage = "Minimo requerido 1")]
        public int? term_CantidadTransportes { get; set; }


        
        [Display(Name = "Estado")]
        public int? term_Estado { get; set; }
        
        [Display(Name = "ID Usuario Creador")]
        public int? term_UsuarioCreador { get; set; }
        
        [Display(Name = "Usuario Creador")]
        public string term_UsuarioCreador_Nombre { get; set; }
        
        [Display(Name = "Fecha Creación")]
        public DateTime? term_FechaCreacion { get; set; }
        
        [Display(Name = "ID Usuario Modificador")]
        public int? term_UsuarioModificador { get; set; }
        
        [Display(Name = "Usuario Modificador")]
        public string term_UsuarioModificador_Nombre { get; set; }
        
        [Display(Name = "Fecha Modificación")]
        public DateTime? term_FechaModificacion { get; set; }
    }
}
