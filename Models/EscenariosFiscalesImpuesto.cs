using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosFiscalesImpuesto
    {
        public decimal Iden { get; set; }
        public decimal EscenariosFiscalesIden { get; set; }
        public decimal EscenariosImpuestosIden { get; set; }
        public int Orden { get; set; }

        public virtual EscenariosFiscale EscenariosFiscalesIdenNavigation { get; set; } = null!;
        public virtual EscenariosImpuesto EscenariosImpuestosIdenNavigation { get; set; } = null!;
    }
}
