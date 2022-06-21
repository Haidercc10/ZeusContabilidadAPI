using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ReportesImpresion
    {
        public decimal IdReportDataBase { get; set; }
        public string? NombreReporte { get; set; }
        public string? Usuario { get; set; }
        public DateTime? Fechagrabacion { get; set; }
        public decimal? IdenSesion { get; set; }
    }
}
