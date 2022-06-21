using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Role
    {
        public Role()
        {
            RolesBus = new HashSet<RolesBu>();
            RolesReglasdelRols = new HashSet<RolesReglasdelRol>();
            RolesUsuarioRols = new HashSet<RolesUsuarioRol>();
        }

        public string Codigo { get; set; } = null!;
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public bool? AplicarEnTodosLosBu { get; set; }
        public int IdenRoles { get; set; }

        public virtual ICollection<RolesBu> RolesBus { get; set; }
        public virtual ICollection<RolesReglasdelRol> RolesReglasdelRols { get; set; }
        public virtual ICollection<RolesUsuarioRol> RolesUsuarioRols { get; set; }
    }
}
