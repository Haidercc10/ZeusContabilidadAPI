using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfPasivo
    {
        public int IdPasivo { get; set; }
        public int IdPadre { get; set; }
        public decimal CxP { get; set; }
        public decimal Pagares { get; set; }
        public decimal ObligacionesHip { get; set; }
        public decimal ObligacionesBan { get; set; }
        public decimal Otros { get; set; }
        public decimal TotalPasivoCte { get; set; }
        public decimal PasivoLargoPlazo { get; set; }
        public decimal PrestHipotecarios { get; set; }
        public decimal OtrosPasivosLp { get; set; }
        public decimal TotalPasivoLp { get; set; }
        public decimal Capital { get; set; }
        public decimal TotalPatrimonio { get; set; }
        public decimal TotalPasivoPatr { get; set; }
        public string TipoEstudio { get; set; } = null!;

        public virtual MfTablapadre MfTablapadre { get; set; } = null!;
    }
}
