using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DocumentosRevertir
    {
        public decimal Iden { get; set; }
        public string IdFuente { get; set; } = null!;
        public string Numdoctra { get; set; } = null!;
        public bool Estado { get; set; }
        public bool Error { get; set; }
        public string? UltimoError { get; set; }
        public string Aplicacion { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaProceso { get; set; }
    }
}
