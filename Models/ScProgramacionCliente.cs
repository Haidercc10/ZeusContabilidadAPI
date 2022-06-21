using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ScProgramacionCliente
    {
        public ScProgramacionCliente()
        {
            ScProgramacionClienteCrts = new HashSet<ScProgramacionClienteCrt>();
        }

        public decimal Iden { get; set; }
        public decimal ConsecutivoProgramacion { get; set; }
        public decimal IdenProgramacion { get; set; }
        public string Cliente { get; set; } = null!;
        public decimal? IdenCobrador { get; set; }
        public decimal FacturasPrg { get; set; }
        public decimal SaldoFact { get; set; }
        public string Vencimiento { get; set; } = null!;
        public string Prioridad { get; set; } = null!;
        public decimal? IdenRelacionado { get; set; }

        public virtual ScCobrador? IdenCobradorNavigation { get; set; }
        public virtual ScProgramacion IdenProgramacionNavigation { get; set; } = null!;
        public virtual ICollection<ScProgramacionClienteCrt> ScProgramacionClienteCrts { get; set; }
    }
}
