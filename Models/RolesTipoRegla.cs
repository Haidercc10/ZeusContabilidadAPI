using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RolesTipoRegla
    {
        public RolesTipoRegla()
        {
            RolesReglas = new HashSet<RolesRegla>();
        }

        public string Codigo { get; set; } = null!;
        public string? Nombre { get; set; }
        public bool? Formulada { get; set; }
        public int IdenRolestiporegla { get; set; }

        public virtual ICollection<RolesRegla> RolesReglas { get; set; }
    }
}
