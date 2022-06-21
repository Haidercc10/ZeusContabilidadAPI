using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DocumentRev
    {
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string? Ncheque { get; set; }
        public decimal? ValorCheque { get; set; }
        public string? Entregado { get; set; }
        public string? TpDocEntregado { get; set; }
        public string? NdocEntregado { get; set; }
        public DateTime? FechaEntregado { get; set; }
        public string? Beneficiario { get; set; }
        public string? ImpresionCheque { get; set; }
        public string? MontoLetras { get; set; }
        public string Moneda { get; set; } = null!;
        public decimal VrMoneda { get; set; }
        public string MontoMoneda { get; set; } = null!;
        public string VencCheque { get; set; } = null!;
        public decimal TasaCambio { get; set; }
        public string Bu { get; set; } = null!;
        public int IdenDocumentRev { get; set; }

        public virtual Bu BuNavigation { get; set; } = null!;
    }
}
