using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RolesHead
    {
        public RolesHead()
        {
            RolesCuentaAuxiliars = new HashSet<RolesCuentaAuxiliar>();
            RolesTablas = new HashSet<RolesTabla>();
        }

        public int Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool BlRolConsultas { get; set; }
        public bool BlRolReportes { get; set; }

        public virtual ICollection<RolesCuentaAuxiliar> RolesCuentaAuxiliars { get; set; }
        public virtual ICollection<RolesTabla> RolesTablas { get; set; }
    }
}
