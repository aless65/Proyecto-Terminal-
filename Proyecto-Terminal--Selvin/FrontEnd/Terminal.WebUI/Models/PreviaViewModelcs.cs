using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Terminal.WebUI.Models
{
    public class PreviaViewModelcs
    {
        [Display(Name = "Id N°")]
        public int bole_ID { get; set; }

        [Display(Name = "Fecha de Viaje")]
        public DateTime? bole_Fecha { get; set; }

        [Display(Name = "Nombre Completo")]
        public string bole_clie_Nombre_Completo { get; set; }

        [Display(Name = "Origen")]

        public string bole_hora_Origen_Nombre { get; set; }

        [Display(Name = "Destino")]

        public string bole_hora_Destino_Nombre { get; set; }

        [Display(Name = "Compania")]

        public string comp_Nombre { get; set; }


    }
}
