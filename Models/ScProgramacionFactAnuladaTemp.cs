using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ScProgramacionFactAnuladaTemp
    {
        public decimal SpId { get; set; }
        public decimal IdenProgramacion { get; set; }
        public string AnoMes { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public string TipoFact { get; set; } = null!;
        public string NumeFact { get; set; } = null!;
        public string VenceFact { get; set; } = null!;
        public string RefeFact { get; set; } = null!;
        public decimal IdenFactura { get; set; }
        public decimal ConsecutivoProgramacion { get; set; }
        public string Vendedor { get; set; } = null!;
        public string Zona { get; set; } = null!;
        public decimal SaldoFact { get; set; }
        public string Prioridad { get; set; } = null!;
        public string Bu { get; set; } = null!;
        public int IdenScProgramacionfactanuladatemp { get; set; }
    }
}
