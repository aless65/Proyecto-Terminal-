    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Terminal.WebUI.Models
{
    public class ClientesModel
    {
        [Display(Name = "Cliente #")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        public int clie_ID { get; set; }


        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "No se aceptan numeros")]
        public string clie_Nombres { get; set; }


        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "No se aceptan numeros")]
        public string clie_Apellidos { get; set; }


        [Display(Name = "Nombre Completo")]
        public string clie_NombreCompleto { get; set; }


        [Display(Name = "DNI")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Solo se aceptan numeros")]
        [MinLength(13, ErrorMessage ="13 digitos requeridos")]
        [MaxLength(13)]
        public string clie_DNI { get; set; }


        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        public string clie_Sexo { get; set; }


        [Display(Name = "Teléfono")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Solo se aceptan numeros")]
        [MinLength(8, ErrorMessage = "8 digitos requeridos")]
        [MaxLength(8)]
        [Phone]
        public string clie_Telefono { get; set; }


        [Display(Name = "Correo Electrónico")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        [EmailAddress]
        public string clie_Email { get; set; }


        [Display(Name = "Estado")]
        public int? clie_Estado { get; set; }


        [Display(Name = "ID Usuario Creador")]
        public int? clie_UsuarioCreador { get; set; }


        [Display(Name = "Usuario Creador")]
        public string clie_UsuarioCreador_Nombre { get; set; }


        [Display(Name = "Fecha Creación")]
        public DateTime? clie_FechaCreacion { get; set; }


        [Display(Name = "ID Usuario Modificador")]
        public int? clie_UsuarioModificador { get; set; }


        [Display(Name = "Usuario Modificador")]
        public string clie_UsuarioModificador_Nombre { get; set; }


        [Display(Name = "Fecha Moficación")]
        public DateTime? clie_FechaModificacion { get; set; }
    }
}
