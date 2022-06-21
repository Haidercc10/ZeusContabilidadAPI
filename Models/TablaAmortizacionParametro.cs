using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TablaAmortizacionParametro
    {
        public int Id { get; set; }
        public decimal? IdenCondicionesdecredito { get; set; }
        public short TipoInteres { get; set; }
        public decimal Monto { get; set; }
        public double Tasa { get; set; }
        public int Plazo { get; set; }
        public DateTime FechaPrimerpago { get; set; }
        public short Decimales { get; set; }
        public int PeriodicidadTasa { get; set; }
        public int CuotasGracia { get; set; }
        public double TasaComparativa { get; set; }
        public decimal? CostosAsociados { get; set; }
        public string? IdMoneda { get; set; }
        public int? IdenLibro { get; set; }
        public decimal? MontoOtraMoneda { get; set; }
        public int? IdenTasaDeMercado { get; set; }
        public int? IdenTasaLocal { get; set; }
        public double? SpreadTasaLocal { get; set; }
        public double? SpreadTasaReferencia { get; set; }
        public decimal IdenCondicionesdecreditoMercado { get; set; }

        public virtual Condicionesdecredito? IdenCondicionesdecreditoNavigation { get; set; }
    }
}
