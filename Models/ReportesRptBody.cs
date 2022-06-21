using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ReportesRptBody
    {
        public decimal IdenReporte { get; set; }
        public string Reporte { get; set; } = null!;
        public byte[]? ReporteCr { get; set; }
        public byte[]? ReporteFr { get; set; }
        public string? ReporteDefecto { get; set; }
        public int IdenReportesrptBody { get; set; }

        public virtual ReportesRpt IdenReporteNavigation { get; set; } = null!;
    }
}
