using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class BienesServiciosValor
    {
        public decimal Iden { get; set; }
        public decimal IdenBienes { get; set; }
        public string FechaIni { get; set; } = null!;
        public string FechaFin { get; set; } = null!;
        public decimal PorcImporte { get; set; }

        public virtual BienesServicio IdenBienesNavigation { get; set; } = null!;
    }
}
