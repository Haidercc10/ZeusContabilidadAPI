using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TerceroCupoCreditoPorMonedum
    {
        public decimal Iden { get; set; }
        public string CodigoTercero { get; set; } = null!;
        public string CodigoMoneda { get; set; } = null!;
        public decimal ValorCupoCredito { get; set; }
    }
}
