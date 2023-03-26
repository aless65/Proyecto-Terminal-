using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Terminal.WebUI.Models
{
    public class BoletosViewModel
    {
        public int bole_ID { get; set; }
        public DateTime? bole_Fecha { get; set; }
        public int? term_ID { get; set; }
        public string term_Nombre { get; set; }
        public string term_DireccionExacta { get; set; }
        public int? comp_ID { get; set; }
        public string comp_Nombre { get; set; }
        public string comp_Direccion { get; set; }
        public int? empl_ID { get; set; }
        public string empl_PrimerNombre { get; set; }
        public string empl_SegundoNombre { get; set; }
        public string empl_PrimerApellido { get; set; }
        public string empl_SegundoApellido { get; set; }
        public string bole_empl_Nombre_Completo { get; set; }
        public int? clie_ID { get; set; }
        public string clie_Nombres { get; set; }
        public string clie_Apellidos { get; set; }
        public string bole_clie_Nombre_Completo { get; set; }
        public string clie_Sexo { get; set; }
        public int? hora_ID { get; set; }
        public DateTime? hora_FechaSalida { get; set; }
        public string hora_Origen { get; set; }
        public string bole_hora_Origen_Nombre { get; set; }
        public DateTime? hora_FechaLlegada { get; set; }
        public string hora_Destino { get; set; }
        public string bole_hora_Destino_Nombre { get; set; }
        public int? pago_ID { get; set; }
        public string pago_Descripcion { get; set; }
        public decimal? bole_Precio { get; set; }
        public int? bole_Estado { get; set; }
        public int? bole_UsuarioCreador { get; set; }
        public string bole_UsuarioCreador_Nombre { get; set; }
        public DateTime? bole_FechaCreacion { get; set; }
        public int? bole_UsuarioModificador { get; set; }
        public string bole_UsuarioModificador_Nombre { get; set; }
        public DateTime? bole_FechaModificacion { get; set; }
    }
}
