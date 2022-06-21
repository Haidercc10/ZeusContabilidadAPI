using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RptCertificado
    {
        public RptCertificado()
        {
            RptCertificadoConceptos = new HashSet<RptCertificadoConcepto>();
        }

        public int Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? SeDeclaraEn { get; set; }
        public string? FormatoReporte { get; set; }

        public virtual ICollection<RptCertificadoConcepto> RptCertificadoConceptos { get; set; }
    }
}
