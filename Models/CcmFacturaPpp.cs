using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CcmFacturaPpp
    {
        public string UnidadDeNegocio { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string? TipoFactura { get; set; }
        public string NumeroFactura { get; set; } = null!;
        public string VencimientoFactura { get; set; } = null!;
        public string? ReferenciaFactura { get; set; }
        public decimal SaldoAnterior { get; set; }
        public decimal MovimientoDebito { get; set; }
        public decimal MovimientoCredito { get; set; }
        public decimal SaldoActual { get; set; }
        public string? Estado { get; set; }
        public string? FechaRecepcion { get; set; }
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
    }
}
