using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DocumentosContingencium
    {
        public int Iden { get; set; }
        public int IdContingencia { get; set; }
        public string IdFuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public bool Procesado { get; set; }
    }
}
