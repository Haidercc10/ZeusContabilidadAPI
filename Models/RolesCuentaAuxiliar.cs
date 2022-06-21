using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RolesCuentaAuxiliar
    {
        public int Iden { get; set; }
        public int IdenRol { get; set; }
        public string Cuenta { get; set; } = null!;
        public int Todo { get; set; }

        public virtual Maecont CuentaNavigation { get; set; } = null!;
        public virtual RolesHead IdenRolNavigation { get; set; } = null!;
    }
}
