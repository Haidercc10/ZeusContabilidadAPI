using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TablaAmortizacion
    {
        public int IdenTablaAmortizacionParametros { get; set; }
        public int Cuota { get; set; }
        public decimal Valorcuota { get; set; }
        public decimal Capital { get; set; }
        public decimal Interes { get; set; }
        public decimal Saldocapital { get; set; }
        public string FechaCuota { get; set; } = null!;
        public decimal Totalcxc { get; set; }
        public int IdenLibro { get; set; }
        public decimal Monto { get; set; }
        public decimal? ValorcuotaMoneda { get; set; }
        public decimal? CapitalMoneda { get; set; }
        public decimal? InteresMoneda { get; set; }
        public decimal? SaldocapitalMoneda { get; set; }
        public decimal? TotalcxcMoneda { get; set; }
        public decimal? MontoMoneda { get; set; }
        public int IdenTablaamortizacion { get; set; }

        public virtual TablaAmortizacionParametro IdenTablaAmortizacionParametrosNavigation { get; set; } = null!;
    }
}
