using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VwFinancierasPlanesDePago
    {
        public int Id { get; set; }
        public string Idcliente { get; set; } = null!;
        public string? Cliente { get; set; }
        public string Tipofactura { get; set; } = null!;
        public string Factura { get; set; } = null!;
        public decimal? Monto { get; set; }
        public string Tipoventacompra { get; set; } = null!;
        public string? Moneda { get; set; }
    }
}
