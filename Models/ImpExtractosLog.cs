using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ImpExtractosLog
    {
        public long Iden { get; set; }
        public decimal IdenArchivo { get; set; }
        public string Path { get; set; } = null!;
        public int Consolidado { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public string Serie { get; set; } = null!;
        public string DocumentoI { get; set; } = null!;
        public string DocumentoF { get; set; } = null!;
        public string Bu { get; set; } = null!;

        public virtual ImpExtractosDefinicion IdenArchivoNavigation { get; set; } = null!;
    }
}
