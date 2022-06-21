using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfEscEgreso
    {
        public int IdEgresos { get; set; }
        public int IdescPadre { get; set; }
        public decimal Arriendo { get; set; }
        public decimal Gastos { get; set; }
        public decimal Deudas { get; set; }
        public decimal Totalegresos { get; set; }

        public virtual MfEscTablapadre IdescPadreNavigation { get; set; } = null!;
    }
}
