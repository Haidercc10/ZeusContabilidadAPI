using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusDatosAplicacion
    {
        public decimal Iden { get; set; }
        public string? Aplicacion { get; set; }
        public string? VersionEjecutable { get; set; }
        public string? RevisionEjecutable { get; set; }
        public string? ServicePack { get; set; }
        public DateTime? FechaSp { get; set; }
    }
}
