using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RolesObjetosValidacionParametrosEntrada
    {
        public string RolObjetoValidacion { get; set; } = null!;
        public string RolParametroEntrada { get; set; } = null!;
        public int IdenRolesobjetosvalidacionparametrosentradas { get; set; }

        public virtual RolesObjetosValidacion RolObjetoValidacionNavigation { get; set; } = null!;
        public virtual RolesParametrosEntradum RolParametroEntradaNavigation { get; set; } = null!;
    }
}
