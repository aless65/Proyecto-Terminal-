﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Terminal.Entities.Entities
{
    public partial class tbPantallas
    {
        public tbPantallas()
        {
            tbRolesXPantallas = new HashSet<tbRolesXPantallas>();
        }

        public int pant_ID { get; set; }
        public string pant_Descripcion { get; set; }
        public int? pant_Estado { get; set; }
        public int? pant_UsuarioCreador { get; set; }
        public DateTime? pant_FechaCreacion { get; set; }
        public int? pant_UsuarioModificador { get; set; }
        public DateTime? pant_FechaModificacion { get; set; }

        public virtual tbUsuarios pant_UsuarioCreadorNavigation { get; set; }
        public virtual tbUsuarios pant_UsuarioModificadorNavigation { get; set; }
        public virtual ICollection<tbRolesXPantallas> tbRolesXPantallas { get; set; }
    }
}