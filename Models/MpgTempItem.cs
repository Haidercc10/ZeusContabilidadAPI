using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MpgTempItem
    {
        public int Iden { get; set; }
        public int SpId { get; set; }
        public string Rubro { get; set; } = null!;
        public string Recurso { get; set; } = null!;
        public string? CentroCosto { get; set; }
        public string? CuentaDebito { get; set; }
        public string? CuentaCredito { get; set; }
        public string? CuentaDebitoOrden { get; set; }
        public string? CuentaCreditoOrden { get; set; }
        public string? DescripcionDebito { get; set; }
        public string? DescripcionCredito { get; set; }
        public decimal Valor { get; set; }
    }
}
