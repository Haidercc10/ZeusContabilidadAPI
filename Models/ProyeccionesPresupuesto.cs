using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ProyeccionesPresupuesto
    {
        public string Codipresu { get; set; } = null!;
        public string Codcco { get; set; } = null!;
        public string? Tipocta { get; set; }
        public string? Coddcta { get; set; }
        public string AnoOrigen { get; set; } = null!;
        public string Anomescta { get; set; } = null!;
        public decimal? Valorpresu { get; set; }
        public decimal? ValorContabilidad { get; set; }
        public decimal? PorPresupuesto { get; set; }
        public decimal? PorContabilidad { get; set; }
        public decimal? Porcentaje { get; set; }
        public decimal? PresupuestoProyectado { get; set; }
        public string Bu { get; set; } = null!;
        public int IdenProyeccionespresupuesto { get; set; }

        public virtual Bu BuNavigation { get; set; } = null!;
    }
}
