using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactBodyDocumentoModelo
    {
        public decimal Iden { get; set; }
        public string FuenteFbo { get; set; } = null!;
        public string DocumFbo { get; set; } = null!;
        public int ConsecuFbo { get; set; }
        public string? IdDocumentoAuto { get; set; }
    }
}
