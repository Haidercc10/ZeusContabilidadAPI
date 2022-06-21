using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ScProgramacionFactura
    {
        public ScProgramacionFactura()
        {
            ScProgramacionFactCriterios = new HashSet<ScProgramacionFactCriterio>();
        }

        public decimal Iden { get; set; }
        public decimal ConsecutivoProgramacion { get; set; }
        public decimal IdenProgramacion { get; set; }
        public string AnoMes { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public string TipoFact { get; set; } = null!;
        public string NumeFact { get; set; } = null!;
        public string VenceFact { get; set; } = null!;
        public string RefeFact { get; set; } = null!;
        public string Vendedor { get; set; } = null!;
        public string Zona { get; set; } = null!;
        public decimal SaldoFact { get; set; }
        public string Prioridad { get; set; } = null!;
        public string Bu { get; set; } = null!;
        public decimal TotalMora { get; set; }
        public decimal TotalIvaMora { get; set; }

        public virtual ScProgramacion IdenProgramacionNavigation { get; set; } = null!;
        public virtual ICollection<ScProgramacionFactCriterio> ScProgramacionFactCriterios { get; set; }
    }
}
