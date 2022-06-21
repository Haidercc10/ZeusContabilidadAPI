using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RptCertificadoConceptoCuentum
    {
        public int Iden { get; set; }
        public int? IdenRptCertificadoConcepto { get; set; }
        public string CodiCta { get; set; } = null!;

        public virtual RptCertificadoConcepto? IdenRptCertificadoConceptoNavigation { get; set; }
    }
}
