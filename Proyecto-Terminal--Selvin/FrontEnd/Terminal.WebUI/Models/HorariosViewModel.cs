using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Terminal.WebUI.Models
{
    public class HorariosViewModel
    {
        [Display(Name = "Horario N°")]
        public int hora_ID { get; set; }


        [Display(Name = "Fecha/Hora salida")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        [DataType(DataType.DateTime)]
        public DateTime? hora_FechaSalida { get; set; }


        [Display(Name = "Fecha/Hora llegada")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        [DataType(DataType.DateTime)]
        public DateTime? hora_FechaLlegada { get; set; }

        [Display(Name = "Viaje")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        public string horario { get; set; }
        [Display(Name = "Orígen")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        public string hora_Origen { get; set; }


        [Display(Name = "Orígen")]
        public string hora_Origen_DeptoNombre { get; set; }


        [Display(Name = "Destino")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        public string hora_Destino { get; set; }
        
       
        [Display(Name = "Destino")]
        public string hora_Destino_DeptoNombre { get; set; }


        [Display(Name = "Pasajeros")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Solo se aceptan numeros")]
        public int? hora_CantidadPasajeros { get; set; }


        [Display(Name = "Precio")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Solo se aceptan numeros")]
        public decimal? hora_Precio { get; set; }


        [Display(Name = "Estado")]
        public int? hora_Estado { get; set; }


        [Display(Name = "ID Usuario Creador")]
        public int? hora_UsuarioCreador { get; set; }


        [Display(Name = "Usuario Creador")]
        public string hora_UsuarioCreador_Nombre { get; set; }


        [Display(Name = "Fecha Creación")]
        public DateTime? hora_FechaCreacion { get; set; }


        [Display(Name = "ID Usuario Modificador")]
        public int? hora_UsuarioModificador { get; set; }


        [Display(Name = "Usuario Modificador")]
        public string hora_UsuarioModificador_Nombre { get; set; }


        [Display(Name = "Fecha Modificación")]
        public DateTime? hora_FechaModificacion { get; set; }
    }
}
