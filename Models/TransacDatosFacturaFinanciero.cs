using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TransacDatosFacturaFinanciero
    {
        public decimal Iden { get; set; }
        public int Consecutra { get; set; }
        public double FactPorcentajeInteresPactado { get; set; }
        public double FactPorcentajeInteresComparativo { get; set; }
        public decimal FactIdencondicionesdecredito { get; set; }
        public string Codicta { get; set; } = null!;
        public string Idcliprv { get; set; } = null!;
        public string Tipofac { get; set; } = null!;
        public string Numefac { get; set; } = null!;
        public string Vencefac { get; set; } = null!;
        public string Refefac { get; set; } = null!;
        public string Bu { get; set; } = null!;
        public int? Cuota { get; set; }
        public int? Plazo { get; set; }
        public decimal? ValorPrestamo { get; set; }
        public decimal? ValorCuota { get; set; }
        public decimal? CostosAsociados { get; set; }
        public int? CuotasGracia { get; set; }
        public int? ConsecutivoCredito { get; set; }
    }
}
