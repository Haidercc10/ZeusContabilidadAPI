using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactheadTempError
    {
        public decimal Id { get; set; }
        public string? Fuente { get; set; }
        public string? Documento { get; set; }
        public int? Consecutivo { get; set; }
        public string? Error { get; set; }
    }
}
