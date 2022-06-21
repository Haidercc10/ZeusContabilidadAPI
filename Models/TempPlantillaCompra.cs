using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TempPlantillaCompra
    {
        public decimal Iden { get; set; }
        public decimal Spid { get; set; }
        public string Fecha { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string CuentaPorPagar { get; set; } = null!;
        public string Bu { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public double TasaCambio { get; set; }
        public string Item { get; set; } = null!;
        public string CentroCosto { get; set; } = null!;
        public string TipoFactura { get; set; } = null!;
        public string NumeroFactura { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public int DiasVencimiento { get; set; }
        public int Cuotas { get; set; }
        public string Concepto { get; set; } = null!;
        public int Cantidad { get; set; }
        public decimal ValorUnitario { get; set; }
        public string BuConcepto { get; set; } = null!;
    }
}
