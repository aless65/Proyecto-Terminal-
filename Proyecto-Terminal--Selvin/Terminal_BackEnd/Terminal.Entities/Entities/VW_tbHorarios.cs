﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Terminal.Entities.Entities
{
    public partial class VW_tbHorarios
    {
        public int hora_ID { get; set; }
        public DateTime? hora_Salida { get; set; }
        public DateTime? hora_Llegada { get; set; }
        public string hora_Origen { get; set; }
        public string hora_Origen_DeptoNombre { get; set; }
        public string hora_Destino { get; set; }
        public string hora_Destino_DeptoNombre { get; set; }
        public string horario { get; set; }
        public int? hora_CantidadPasajerosMax { get; set; }
        public int? hora_CantidadPasajerosActual { get; set; }
        public decimal? hora_Precio { get; set; }
        public int? hora_Estado { get; set; }
        public int? hora_UsuarioCreador { get; set; }
        public string hora_UsuarioCreador_Nombre { get; set; }
        public DateTime? hora_FechaCreacion { get; set; }
        public int? hora_UsuarioModificador { get; set; }
        public string hora_UsuarioModificador_Nombre { get; set; }
        public DateTime? hora_FechaModificacion { get; set; }
    }
}