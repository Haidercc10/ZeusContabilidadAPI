using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RolesObjetosValidacion
    {
        public RolesObjetosValidacion()
        {
            RolesObjetosValidacionParametrosEntrada = new HashSet<RolesObjetosValidacionParametrosEntrada>();
            RolesReglas = new HashSet<RolesRegla>();
        }

        public string Codigo { get; set; } = null!;
        public string? Nombre { get; set; }
        public int IdenRolesobjetosvalidacion { get; set; }

        public virtual ICollection<RolesObjetosValidacionParametrosEntrada> RolesObjetosValidacionParametrosEntrada { get; set; }
        public virtual ICollection<RolesRegla> RolesReglas { get; set; }
    }
}
