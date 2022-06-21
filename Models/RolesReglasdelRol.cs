using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RolesReglasdelRol
    {
        public string Rol { get; set; } = null!;
        public decimal Regla { get; set; }
        public int IdenRolesreglasdelrol { get; set; }

        public virtual RolesRegla ReglaNavigation { get; set; } = null!;
        public virtual Role RolNavigation { get; set; } = null!;
    }
}
