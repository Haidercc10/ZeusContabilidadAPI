using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusFwErrore
    {
        public decimal IdError { get; set; }
        public string DsCodigo { get; set; } = null!;
        public string? DsNombreForm { get; set; }
        public string? DsSpForm { get; set; }
        public string DsMetodoError { get; set; } = null!;
        public string DsTipo { get; set; } = null!;
        public string DsMensajeError { get; set; } = null!;
        public string DsTrace { get; set; } = null!;
        public DateTime? DtError { get; set; }
    }
}
