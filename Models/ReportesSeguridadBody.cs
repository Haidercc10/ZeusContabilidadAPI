using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ReportesSeguridadBody
    {
        public int IdenHead { get; set; }
        public int IdenReporte { get; set; }
        public int IndModificar { get; set; }
        public int IndImprimir { get; set; }
        public int IndEliminar { get; set; }
        public int IdenReportesseguridadBody { get; set; }
    }
}
