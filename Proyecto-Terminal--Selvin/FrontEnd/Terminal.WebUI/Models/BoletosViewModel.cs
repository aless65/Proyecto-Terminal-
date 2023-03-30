using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Terminal.WebUI.Models
{
    public class BoletosViewModel
    {
        [Display(Name = "Boleto N°")]
        public int bole_ID { get; set; }
        

        [Display(Name = "Fecha")]
        public DateTime? bole_Fecha { get; set; }


        [Display(Name = "Terminal")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        public int? term_ID { get; set; }


        [Display(Name = "Terminal")]
        public string term_Nombre { get; set; }


        [Display(Name = "Dirección")]
        public string term_DireccionExacta { get; set; }


        [Display(Name = "Compañia")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        public int? comp_ID { get; set; }


        [Display(Name = "Compañia")]
        public string comp_Nombre { get; set; }

        [Display(Name = "Dirección de la compañia")]
        public string comp_Direccion { get; set; }


        [Display(Name = "Empleado")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        public int? empl_ID { get; set; }


        [Display(Name = "Primer Nombre")]
        public string empl_PrimerNombre { get; set; }


        [Display(Name = "Segundo Nombre")]
        public string empl_SegundoNombre { get; set; }


        [Display(Name = "Primer Apellido")]
        public string empl_PrimerApellido { get; set; }


        [Display(Name = "Segundo Apellido")]
        public string empl_SegundoApellido { get; set; }


        [Display(Name = "Nombre Completo")]
        public string bole_empl_Nombre_Completo { get; set; }

        [Display(Name = "Cliente")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        public int? clie_ID { get; set; }

        [Display(Name = "Nombres")]
        public string clie_Nombres { get; set; }

        [Display(Name = "Apellidos")]
        public string clie_Apellidos { get; set; }


        [Display(Name = "Nombre completo")]
        public string bole_clie_Nombre_Completo { get; set; }

        [Display(Name = "Sexo")]
        public string clie_Sexo { get; set; }

        [Display(Name = "Horario")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        public int? hora_ID { get; set; }


        [Display(Name = "Fecha/Hora Salida")]
        public DateTime? hora_FechaSalida { get; set; }


        [Display(Name = "Origen ID")]
        public string hora_Origen { get; set; }


        [Display(Name = "Origen")]
        public string bole_hora_Origen_Nombre { get; set; }

        [Display(Name = "Fecha/Hora Llegada")]
        public DateTime? hora_FechaLlegada { get; set; }


        [Display(Name = "Destino ID")]
        public string hora_Destino { get; set; }

        [Display(Name = "Destino")]
        public string bole_hora_Destino_Nombre { get; set; }


        [Display(Name = "Método de pago")]
        [Required(ErrorMessage = "Campo '{0}' requerido")]
        public int? pago_ID { get; set; }

        [Display(Name = "Método de pago")]
        public string pago_Descripcion { get; set; }


        [Display(Name = "Precio")]
        public decimal? hora_Precio { get; set; }

        [Display(Name = "Estado")]
        public int? bole_Estado { get; set; }

        [Display(Name = "ID Usuario Creador")]
        public int? bole_UsuarioCreador { get; set; }


        [Display(Name = "Usuario Creador")]
        public string bole_UsuarioCreador_Nombre { get; set; }


        [Display(Name = "Fecha Creación")]
        public DateTime? bole_FechaCreacion { get; set; }


        [Display(Name = "ID Usuario Modificador")]
        public int? bole_UsuarioModificador { get; set; }


        [Display(Name = "Usuario Modificador")]
        public string bole_UsuarioModificador_Nombre { get; set; }


        [Display(Name = "Fecha Modificación")]
        public DateTime? bole_FechaModificacion { get; set; }
    }
}
