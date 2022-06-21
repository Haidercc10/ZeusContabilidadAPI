using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfEscIngreso
    {
        public int IdIngresos { get; set; }
        public int IdescPadre { get; set; }
        public decimal Ingmensual { get; set; }
        public decimal Sueldoconyuge { get; set; }
        public decimal Otros { get; set; }
        public decimal Totalingresos { get; set; }

        public virtual MfEscTablapadre IdescPadreNavigation { get; set; } = null!;
    }
}
