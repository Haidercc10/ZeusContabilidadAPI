using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfEscPasivo
    {
        public int IdPasivo { get; set; }
        public int IdescPadre { get; set; }
        public decimal Cxp { get; set; }
        public decimal Pagares { get; set; }
        public decimal Obligacioneship { get; set; }
        public decimal Obligacionesban { get; set; }
        public decimal Otros { get; set; }
        public decimal TotalPasivocte { get; set; }
        public decimal PasivoLargoplazo { get; set; }
        public decimal PrestHipotecarios { get; set; }
        public decimal OtrosPasivoslp { get; set; }
        public decimal TotalPasivolp { get; set; }
        public decimal Capital { get; set; }
        public decimal TotalPatrimonio { get; set; }
        public decimal TotalPasivopatr { get; set; }

        public virtual MfEscTablapadre IdescPadreNavigation { get; set; } = null!;
    }
}
