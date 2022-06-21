using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactHeadAdicional
    {
        public decimal? SpId { get; set; }
        public string? Fuente { get; set; }
        public string? Documento { get; set; }
        public byte[]? QrGenerado { get; set; }
        public string? CodigoControl { get; set; }
        public int IdenFactheadAdicional { get; set; }
    }
}
