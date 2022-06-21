using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Detraccion
    {
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Bu { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string TipoFactura { get; set; } = null!;
        public string NumeroFactura { get; set; } = null!;
        public string Vencimiento { get; set; } = null!;
        public string ReferenciaFactura { get; set; } = null!;
        public string TipoOperacion { get; set; } = null!;
        public string BienServicio { get; set; } = null!;
        public decimal PorcImp { get; set; }
        public decimal Importe { get; set; }
        public decimal Base { get; set; }
        public string Automatica { get; set; } = null!;
        public string PagoProveedor { get; set; } = null!;
        public string NoDeposito { get; set; } = null!;
        public DateTime FechaDeposito { get; set; }
        public string Estado { get; set; } = null!;
        public int IdenDetraccion { get; set; }
    }
}
