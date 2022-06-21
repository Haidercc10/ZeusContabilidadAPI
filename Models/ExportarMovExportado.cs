using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ExportarMovExportado
    {
        public int Consecutra { get; set; }
        public string? Idfuente { get; set; }
        public string? Numdoctra { get; set; }
        public string? Fechatra { get; set; }
        public string? Usuario { get; set; }
        public DateTime? FechaGrabacion { get; set; }
        public int IdenExportarMovexportado { get; set; }
    }
}
