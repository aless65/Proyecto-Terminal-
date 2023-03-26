using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Terminal.API.Models
{
    public class HorariosViewModel
    {
        public int hora_ID { get; set; }
        public DateTime? hora_FechaSalida { get; set; }
        public DateTime? hora_FechaLlegada { get; set; }
        public string hora_Origen { get; set; }
        public string hora_Origen_DeptoNombre { get; set; }
        public string hora_Destino { get; set; }
        public string hora_Destino_DeptoNombre { get; set; }
        public int? hora_CantidadPasajeros { get; set; }
        public int? hora_Estado { get; set; }
        public int? hora_UsuarioCreador { get; set; }
        public string hora_UsuarioCreador_Nombre { get; set; }
        public DateTime? hora_FechaCreacion { get; set; }
        public int? hora_UsuarioModificador { get; set; }
        public string hora_UsuarioModificador_Nombre { get; set; }
        public DateTime? hora_FechaModificacion { get; set; }
    }
}
