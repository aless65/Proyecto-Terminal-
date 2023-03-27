using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Terminal.WebUI.Models
{
    public class CargosViewModel
    {

        [Display(Name = "Cargo ID")]
        public int carg_ID { get; set; }


        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "No se aceptan numeros")]
        public string carg_Nombre { get; set; }


        [Display(Name = "Estado")]
        public int? carg_Estado { get; set; }


        [Display(Name = "ID Usuario Creador")]
        public int? carg_UsuarioCreador { get; set; }


        [Display(Name = "Usuario Creador")]
        public string carg_UsuarioCreador_Nombre { get; set; }


        [Display(Name = "Fecha Creación")]
        public DateTime? carg_FechaCreacion { get; set; }


        [Display(Name = "ID Usuario Modificador")]
        public int? carg_UsuarioModificador { get; set; }


        [Display(Name = "Usuario Modificador")]
        public string carg_UsuarioModificador_Nombre { get; set; }


        [Display(Name = "Fecha Modificación")]
        public DateTime? carg_FechaModificacion { get; set; }
    }
}
