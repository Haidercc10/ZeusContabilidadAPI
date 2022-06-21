using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class HistoricoAjustesMonedum
    {
        public decimal Iden { get; set; }
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public string TipoFactura { get; set; } = null!;
        public string NumeroFactura { get; set; } = null!;
        public string VencimientoFactura { get; set; } = null!;
        public string? ReferenciaFactura { get; set; }
        public string Bu { get; set; } = null!;
        public decimal SaldoLocal { get; set; }
        public decimal SaldoMoneda { get; set; }
        public string FechaAjuste { get; set; } = null!;
        public decimal TasaAjuste { get; set; }
        public decimal ValorAjuste { get; set; }
        public string TipoAjuste { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string MiPc { get; set; } = null!;
        public int Estado { get; set; }
        public DateTime FechaGrabacion { get; set; }
        public string? FuenteRv { get; set; }
        public string? DocumentoRv { get; set; }
        public string? UsuarioRv { get; set; }
        public string? MiPcrv { get; set; }
        public DateTime? FechaGrabacionRv { get; set; }
    }
}
