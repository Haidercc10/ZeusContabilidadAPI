using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusZeusFwBusquedum
    {
        public string DsCodigo { get; set; } = null!;
        public string? DsNombre { get; set; }
        public string? DsSentenciaSelect { get; set; }
    }
}
