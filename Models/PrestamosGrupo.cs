using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class PrestamosGrupo
    {
        public decimal IdPrestamoGrupo { get; set; }
        public decimal IdPrestamoG { get; set; }
        public string? CodCliente { get; set; }
        public decimal Monto { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal VrCuota { get; set; }
        public decimal VrCapacitacion { get; set; }
        public decimal VrEstudio { get; set; }
        public decimal VrSeguros { get; set; }
        public decimal VrComision { get; set; }
        public decimal TotalCuota { get; set; }
        public string Poliza { get; set; } = null!;

        public virtual PrestamosG IdPrestamoGNavigation { get; set; } = null!;
    }
}
