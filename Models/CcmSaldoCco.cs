using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CcmSaldoCco
    {
        public string? Cuenta { get; set; }
        public string? DescripcionCuenta { get; set; }
        public string CentroDeCosto { get; set; } = null!;
        public string DescripcionCentroDeCosto { get; set; } = null!;
        public string? UnidadDeNegocio { get; set; }
        public decimal? SaldoAnterior { get; set; }
        public decimal? MovimientoDebito { get; set; }
        public decimal? MovimientoCredio { get; set; }
        public decimal? SaldoActual { get; set; }
    }
}
