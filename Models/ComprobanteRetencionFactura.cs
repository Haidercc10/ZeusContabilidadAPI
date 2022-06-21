using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ComprobanteRetencionFactura
    {
        public decimal Iden { get; set; }
        public decimal IdenComprobante { get; set; }
        public string Cuenta { get; set; } = null!;
        public string Identificador { get; set; } = null!;
        public string TipoFactura { get; set; } = null!;
        public string NumeroFactura { get; set; } = null!;
        public string VencimientoFactura { get; set; } = null!;
        public string ReferenciaFactura { get; set; } = null!;
        public string Bu { get; set; } = null!;
        public string FechaEmision { get; set; } = null!;
        public decimal ImporteTotal { get; set; }
        public string TipoMoneda { get; set; } = null!;
        public string FechaPago { get; set; } = null!;
        public decimal NumeroPago { get; set; }
        public decimal ImportePagoSinRetencion { get; set; }
        public string MonedaPago { get; set; } = null!;
        public decimal ImporteRetenido { get; set; }
        public string FechaRetencion { get; set; } = null!;
        public decimal ImporteTotalPagar { get; set; }
        public string MonedaReferenciaTipoCambio { get; set; } = null!;
        public string MonedaObjetivoTipoCambio { get; set; } = null!;
        public double FactorTipoCambio { get; set; }
        public string FechaCambio { get; set; } = null!;

        public virtual ComprobanteRetencion IdenComprobanteNavigation { get; set; } = null!;
    }
}
