using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfEscActivo
    {
        public int IdActivo { get; set; }
        public int IdescPadre { get; set; }
        public decimal Caja { get; set; }
        public decimal Bancos { get; set; }
        public decimal Cxc { get; set; }
        public decimal Inventario { get; set; }
        public decimal Semovientes { get; set; }
        public decimal Cosechas { get; set; }
        public decimal Acciones { get; set; }
        public decimal TotalActivocte { get; set; }
        public decimal Activofijo { get; set; }
        public decimal Terrenos { get; set; }
        public decimal Edificaciones { get; set; }
        public decimal Vehiculos { get; set; }
        public decimal Muebles { get; set; }
        public decimal OtrosActivosfijos { get; set; }
        public decimal TotalActivosfijos { get; set; }
        public decimal OtrosActivos { get; set; }
        public decimal TotalActivos { get; set; }

        public virtual MfEscTablapadre IdescPadreNavigation { get; set; } = null!;
    }
}
