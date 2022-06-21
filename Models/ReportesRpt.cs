using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ReportesRpt
    {
        public ReportesRpt()
        {
            ReportesRptBodies = new HashSet<ReportesRptBody>();
        }

        public decimal Id { get; set; }
        public string Categoria { get; set; } = null!;
        public string NombreOpcion { get; set; } = null!;
        public string NombreForma { get; set; } = null!;
        public string? Reporte { get; set; }
        public string? StoreProcedure { get; set; }
        public string? Subreportes { get; set; }
        public string? Descripcion { get; set; }
        public int? AdicionadoPorusuario { get; set; }
        public string TipoReporte { get; set; } = null!;
        public bool Mostrar { get; set; }
        public int? TipoVentana { get; set; }
        public int IdenReportesrpt { get; set; }
        public bool? IndicadorParametrosAdicionales { get; set; }
        public string? NombreControlador { get; set; }

        public virtual ICollection<ReportesRptBody> ReportesRptBodies { get; set; }
    }
}
