using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CcmPago3ro
    {
        public string? Cuenta { get; set; }
        public string? DescripcionCuenta { get; set; }
        public string CodigoTercero { get; set; } = null!;
        public string DescripcionTercero { get; set; } = null!;
        public string? UnidadDeNegocio { get; set; }
        public decimal? SaldoAnterior { get; set; }
        public decimal? MovimientoDebito { get; set; }
        public decimal? MovimientoCredio { get; set; }
        public decimal? SaldoActual { get; set; }
    }
}
