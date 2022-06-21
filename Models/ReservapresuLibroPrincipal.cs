using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ReservapresuLibroPrincipal
    {
        public string Codcta { get; set; } = null!;
        public string Codcco { get; set; } = null!;
        public string Nreserva { get; set; } = null!;
        public decimal? Certificado { get; set; }
        public string? Observacion { get; set; }
        public string? Identificacion { get; set; }
        public string? Beneficiario { get; set; }
        public string? Fecha { get; set; }
        public string Anomes { get; set; } = null!;
        public decimal? Valorreserva { get; set; }
        public decimal? Saldo { get; set; }
        public decimal? Mcredito { get; set; }
        public decimal? Mdebito { get; set; }
        public string? Estado { get; set; }
        public decimal? Trasladodb { get; set; }
        public decimal? Trasladocr { get; set; }
        public decimal? Valorordenado { get; set; }
        public int? Automatica { get; set; }
    }
}
