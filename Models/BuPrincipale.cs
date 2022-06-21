using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class BuPrincipale
    {
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte Habilitar { get; set; }
        public string? CuentaCompensacion { get; set; }
        public byte? NivelBu { get; set; }
        public string? DepenBu { get; set; }
        public DateTime? FecBu { get; set; }
        public int? Ncdcbu { get; set; }
        public string? TipoBu { get; set; }
    }
}
