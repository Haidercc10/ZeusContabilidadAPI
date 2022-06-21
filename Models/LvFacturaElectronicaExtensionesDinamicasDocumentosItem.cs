using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class LvFacturaElectronicaExtensionesDinamicasDocumentosItem
    {
        public string? Fuente { get; set; }
        public string? Documento { get; set; }
        public string? TipoConcepto { get; set; }
        public string? CodigoConcepto { get; set; }
        public string? ConsecutivoVariable { get; set; }
        public string? Usuario { get; set; }
        public string Cliente { get; set; } = null!;
        public string? Vendedor { get; set; }
        public string? CuentaPorCobrar { get; set; }
        public string? CuentaCaja { get; set; }
        public string? Moneda { get; set; }
        public string? CentroCosto { get; set; }
        public string TipoFactura { get; set; } = null!;
        public string? CuentaAnticipo { get; set; }
        public string? Auxiliar { get; set; }
        public string? Item { get; set; }
        public string Bu { get; set; } = null!;
        public string? Propiedad1 { get; set; }
        public string? Propiedad2 { get; set; }
        public string? Propiedad3 { get; set; }
        public string? Propiedad4 { get; set; }
        public string? Propiedad5 { get; set; }
        public int Utilitario { get; set; }
    }
}
