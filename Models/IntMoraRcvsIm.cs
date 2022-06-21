using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class IntMoraRcvsIm
    {
        public int Iden { get; set; }
        public string FuenteRc { get; set; } = null!;
        public string DocumentoRc { get; set; } = null!;
        public string FechaRc { get; set; } = null!;
        public string FuenteIm { get; set; } = null!;
        public string DocumentoIm { get; set; } = null!;
        public string FechaIm { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public int Automatica { get; set; }
    }
}
