using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Terminal.WebUI.Models
{
    public class CargosViewModel
    {
        [Display(Name ="ID")]
        public int carg_ID { get; set; }
        [Display(Name = "Cargo")]
        public string carg_Nombre { get; set; }
        [Display(Name = "Estado")]
        public int? carg_Estado { get; set; }
        [Display(Name = "Usuario Creador ID")]
        public int? carg_UsuarioCreador { get; set; }
        [Display(Name = "Usuario Creacion")]
        public string carg_UsuarioCreador_Nombre { get; set; }
        [Display(Name = "Fecha Creacion")]
        public DateTime? carg_FechaCreacion { get; set; }
        [Display(Name = "Usuario Modificacion ID")]
        public int? carg_UsuarioModificador { get; set; }
        [Display(Name = "Usuario Modificacion")]
        public string carg_UsuarioModificador_Nombre { get; set; }
        [Display(Name = "Fecha Modificacion")]
        public DateTime? carg_FechaModificacion { get; set; }
    }
}
