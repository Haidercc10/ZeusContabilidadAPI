using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CcmSaldoCont
    {
        public string Cuenta { get; set; } = null!;
        public string DescripcionCuenta { get; set; } = null!;
        public string? UnidadDeNegocio { get; set; }
        public decimal? SaldoAnterior { get; set; }
        public decimal? MovimientoDebito { get; set; }
        public decimal? MovimientoCredio { get; set; }
        public decimal? SaldoActual { get; set; }
    }
}
