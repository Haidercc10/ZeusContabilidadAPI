using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusFwReportesLog
    {
        public decimal IdLog { get; set; }
        public int InOrden { get; set; }
        public string DsCodigoRpt { get; set; } = null!;
        public string DsXml { get; set; } = null!;
        public string? IdUsuario { get; set; }
        public DateTime? DtFecha { get; set; }
        public string? DsObservaciones { get; set; }
        public bool? BtEstandar { get; set; }
    }
}
