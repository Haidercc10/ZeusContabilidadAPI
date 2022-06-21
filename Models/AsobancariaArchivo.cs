using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AsobancariaArchivo
    {
        public decimal? Consecutivo { get; set; }
        public decimal? Linea { get; set; }
        public string? Texto { get; set; }
        public bool? Procesado { get; set; }
        public string? Error { get; set; }
        public int IdenAsobancariaArchivo { get; set; }
    }
}
