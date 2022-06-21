using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AsobancariaResumenArchivo
    {
        public decimal Id { get; set; }
        public decimal? Consecutivo { get; set; }
        public string? Referencia1 { get; set; }
        public string? Referencia2 { get; set; }
        public decimal? TotalRecaudo { get; set; }
    }
}
