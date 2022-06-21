using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RolesUsuarioRol
    {
        public decimal Usuario { get; set; }
        public string Rol { get; set; } = null!;
        public int IdenRolesusuariorol { get; set; }

        public virtual Role RolNavigation { get; set; } = null!;
    }
}
