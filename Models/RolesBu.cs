using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RolesBu
    {
        public string Rol { get; set; } = null!;
        public string Bu { get; set; } = null!;
        public int IdenRolesBu { get; set; }

        public virtual Role RolNavigation { get; set; } = null!;
    }
}
