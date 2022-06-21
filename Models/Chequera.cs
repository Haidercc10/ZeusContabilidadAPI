using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Chequera
    {
        public string Banco { get; set; } = null!;
        public string Chequera1 { get; set; } = null!;
        public decimal Ncheque { get; set; }
        public string? Fuente { get; set; }
        public string? Dcto { get; set; }
        public string? Fecha { get; set; }
        public string? Beneficiario { get; set; }
        public decimal? Valor { get; set; }
        public string Estado { get; set; } = null!;
        public string? Aviso { get; set; }
        public string? Entregado { get; set; }
        public string? Tprecdcto { get; set; }
        public string? Ndrecdcto { get; set; }
        public DateTime? Enfdcto { get; set; }
        public string? Impricheque { get; set; }
        public string Prefijo { get; set; } = null!;
        public int IdenChequeras { get; set; }
    }
}
