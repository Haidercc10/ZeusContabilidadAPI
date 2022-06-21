using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturasVsCobro
    {
        public decimal Iden { get; set; }
        public string Cuenta { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public string TipoFactura { get; set; } = null!;
        public string NumeroFactura { get; set; } = null!;
        public string Vencimiento { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public decimal ValorInicial { get; set; }
        public decimal? ValorInicialMoneda { get; set; }
        public string? Fecha { get; set; }
        public string? Fuente { get; set; }
        public string? Documento { get; set; }
        public decimal? IdenPersonaCobro { get; set; }
        public string Bu { get; set; } = null!;
        public string? AjusteCxP { get; set; }
        public string? Adicional1 { get; set; }
        public string? Adicional2 { get; set; }

        public virtual Maecont CuentaNavigation { get; set; } = null!;
        public virtual ScCobrador? IdenPersonaCobroNavigation { get; set; }
        public virtual Tipofact TipoFacturaNavigation { get; set; } = null!;
    }
}
