using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactdocPago
    {
        public decimal Iden { get; set; }
        public string FuentePag { get; set; } = null!;
        public string DocumentoPag { get; set; } = null!;
        public string? MonedaPag { get; set; }
        public decimal ValorpagoPag { get; set; }
        public decimal ValorpagomonedaPag { get; set; }
        public string? DocumentoconPag { get; set; }
        public string? BancoPag { get; set; }
        public string? PlazaPag { get; set; }
        public string? AutorizacionPag { get; set; }
        public string? ReferenciaPag { get; set; }
        public string? FechaPag { get; set; }
        public DateTime Fechagrabacion { get; set; }
        public string FuenteExportPag { get; set; } = null!;
        public string DocumentoExportPag { get; set; } = null!;
        public decimal? IdenRelacionado { get; set; }
        public decimal IvainformadoPag { get; set; }

        public virtual Fuente FuentePagNavigation { get; set; } = null!;
    }
}
