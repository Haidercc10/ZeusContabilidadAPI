using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VariableRollOperacion
    {
        public int IdenRoll { get; set; }
        public decimal IdenMaestro { get; set; }
        public decimal IdenVariable { get; set; }
        public int Creacion { get; set; }
        public int Modificacion { get; set; }
        public int IdenVariablerolloperacion { get; set; }

        public virtual VariableDefinicionMaestro IdenMaestroNavigation { get; set; } = null!;
        public virtual VariableRole IdenRollNavigation { get; set; } = null!;
        public virtual VariableDefinicion IdenVariableNavigation { get; set; } = null!;
    }
}
