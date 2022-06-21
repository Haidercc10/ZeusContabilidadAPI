using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfActivo
    {
        public int IdActivo { get; set; }
        public int IdPadre { get; set; }
        public decimal Caja { get; set; }
        public decimal Bancos { get; set; }
        public decimal CxC { get; set; }
        public decimal Inventario { get; set; }
        public decimal Semovientes { get; set; }
        public decimal Cosechas { get; set; }
        public decimal Acciones { get; set; }
        public decimal TotalActivoCte { get; set; }
        public decimal ActivoFijo { get; set; }
        public decimal Terrenos { get; set; }
        public decimal Edificaciones { get; set; }
        public decimal Vehiculos { get; set; }
        public decimal Muebles { get; set; }
        public decimal OtrosActivosFijos { get; set; }
        public decimal TotalActivosFijos { get; set; }
        public decimal OtrosActivos { get; set; }
        public decimal TotalActivos { get; set; }
        public string TipoEstudio { get; set; } = null!;

        public virtual MfTablapadre MfTablapadre { get; set; } = null!;
    }
}
