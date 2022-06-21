using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TempConcepto
    {
        public int SpId { get; set; }
        public string Clasificacion { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public int IdenTempconceptos { get; set; }
    }
}
