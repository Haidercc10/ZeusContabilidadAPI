using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Factcxcanticipo
    {
        public decimal Id { get; set; }
        public string? Fuente { get; set; }
        public string? Documento { get; set; }
        public string? CuentaCxc { get; set; }
        public decimal? ValorAnticipo { get; set; }
        public string? Estado { get; set; }
    }
}
