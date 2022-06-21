using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactConcVarImpuesto
    {
        public decimal Iden { get; set; }
        public string ConcFco { get; set; } = null!;
        public decimal PorceivaFco { get; set; }
        public string Cuenta { get; set; } = null!;
        public bool Defoult { get; set; }

        public virtual Factconc ConcFcoNavigation { get; set; } = null!;
    }
}
