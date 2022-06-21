using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ScProgramacionFactCriterio
    {
        public decimal IdenProgramacion { get; set; }
        public decimal IdenFactura { get; set; }
        public decimal IdenCriterio { get; set; }
        public int Valor { get; set; }
        public string Observacion { get; set; } = null!;
        public DateTime? Fecha { get; set; }
        public decimal? ValorNumerico { get; set; }
        public int IdenScProgramacionfactcriterios { get; set; }

        public virtual ScCriteriosDeCobro IdenCriterioNavigation { get; set; } = null!;
        public virtual ScProgramacionFactura IdenFacturaNavigation { get; set; } = null!;
    }
}
