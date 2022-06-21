using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContPppProgramacionesConciliacione
    {
        public decimal Iden { get; set; }
        public decimal IdenProgramacion { get; set; }
        public decimal Consecutivo { get; set; }
        public DateTime FechaGrabacion { get; set; }
        public string FuenteConciliacion { get; set; } = null!;
        public string DocumentoConciliacion { get; set; } = null!;
        public string FechaConciliacion { get; set; } = null!;
        public string? DescripcionConciliacion { get; set; }
        public string? ItemConciliacion { get; set; }
    }
}
