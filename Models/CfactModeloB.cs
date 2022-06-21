using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CfactModeloB
    {
        public string Codigo { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public int IdenCfactModelob { get; set; }

        public virtual CfactModeloH CodigoNavigation { get; set; } = null!;
        public virtual Factconc ConceptoNavigation { get; set; } = null!;
    }
}
