using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactheadTemp
    {
        public decimal Id { get; set; }
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public int Consecutivo { get; set; }
        public string Fecha { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public string FormaPago { get; set; } = null!;
        public string TipoFac { get; set; } = null!;
        public int? DiasVen { get; set; }
        public string? Ctacaja { get; set; }
        public string? Ctacxc { get; set; }
        public string? Referencia { get; set; }
        public decimal VrAnticipo { get; set; }
        public string? Ctaanticipo { get; set; }
        public string? Observacion { get; set; }
        public string? Vendedor { get; set; }
        public string? Moneda { get; set; }
        public decimal? TasaCambio { get; set; }
        public string? FechaTcambio { get; set; }
        public string? CentroCosto { get; set; }
        public string? Auxiliar { get; set; }
        public string? Bu { get; set; }
        public int? Procesado { get; set; }
        public int? Anular { get; set; }
        public int? Error { get; set; }
        public DateTime FechaGrabacion { get; set; }
        public string? Item { get; set; }
        public string? Descripcion { get; set; }
        public string? FechaPs { get; set; }
    }
}
