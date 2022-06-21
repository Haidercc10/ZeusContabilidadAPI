using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContSistemasAperturaLibroDiferecia
    {
        public decimal? Iden { get; set; }
        public decimal? IdenPreparacion { get; set; }
        public string? Bu { get; set; }
        public string? Cuenta { get; set; }
        public string? Establecer { get; set; }
        public decimal? Tasa { get; set; }
        public decimal? DiferenciaTotal { get; set; }
        public decimal? DiferenciaFiscal { get; set; }
        public decimal? SaldoFiscal { get; set; }
        public int IdenContSistemasAperturalibroDiferecias { get; set; }
    }
}
