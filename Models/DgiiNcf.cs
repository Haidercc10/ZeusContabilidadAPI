using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DgiiNcf
    {
        public int Iden { get; set; }
        public int Consecutra { get; set; }
        public string? Tercero { get; set; }
        public string Ncf { get; set; } = null!;
        public DateTime Fechacreacion { get; set; }
    }
}
