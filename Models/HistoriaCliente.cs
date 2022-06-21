using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class HistoriaCliente
    {
        public decimal Nrobloqueo { get; set; }
        public string Idcliente { get; set; } = null!;
        public DateTime? Fechabloqueo { get; set; }
        public string? Causa { get; set; }
        public string? Explicacion { get; set; }
        public string? Bloqueador { get; set; }
        public string Tipo { get; set; } = null!;
    }
}
