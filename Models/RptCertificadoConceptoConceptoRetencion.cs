using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RptCertificadoConceptoConceptoRetencion
    {
        public int Iden { get; set; }
        public int? IdenRptCertificadoConcepto { get; set; }
        public string? IdenEscenariosConceptoRetencion { get; set; }

        public virtual RptCertificadoConcepto? IdenRptCertificadoConceptoNavigation { get; set; }
    }
}
