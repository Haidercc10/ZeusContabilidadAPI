using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TransacTerceroDetallado
    {
        public decimal Consecutra { get; set; }
        public string Nittra { get; set; } = null!;
        public decimal Valortra { get; set; }
        public decimal Valormoneda { get; set; }
        public decimal? Porretetra { get; set; }
        public decimal? Baseretetra { get; set; }
        public string? Adicional1 { get; set; }
        public string? Adicional2 { get; set; }
        public string? Adicional3 { get; set; }
        public string? Adicional4 { get; set; }
        public int IdenTransacTercerodetallado { get; set; }
    }
}
