using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class InterfazAsignaVariable
    {
        public decimal Iden { get; set; }
        public decimal InterfazProcesoIden { get; set; }
        public decimal InterfazVariablesIden { get; set; }

        public virtual InterfazProceso InterfazProcesoIdenNavigation { get; set; } = null!;
        public virtual InterfazVariable InterfazVariablesIdenNavigation { get; set; } = null!;
    }
}
