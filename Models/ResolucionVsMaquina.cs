using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ResolucionVsMaquina
    {
        public decimal Iden { get; set; }
        public decimal IdenResolucion { get; set; }
        public decimal IdenMaquina { get; set; }

        public virtual MaquinasHost IdenMaquinaNavigation { get; set; } = null!;
        public virtual ResolucionesDeFactura IdenResolucionNavigation { get; set; } = null!;
    }
}
