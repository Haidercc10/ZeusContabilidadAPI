using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RolesTabla
    {
        public RolesTabla()
        {
            RolesBodies = new HashSet<RolesBody>();
        }

        public int Iden { get; set; }
        public int IdenRol { get; set; }
        public string Tabla { get; set; } = null!;
        public string TipoRol { get; set; } = null!;
        public int Todo { get; set; }

        public virtual RolesHead IdenRolNavigation { get; set; } = null!;
        public virtual ICollection<RolesBody> RolesBodies { get; set; }
    }
}
