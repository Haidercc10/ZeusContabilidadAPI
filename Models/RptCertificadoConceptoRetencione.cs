using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RptCertificadoConceptoRetencione
    {
        public int Iden { get; set; }
        public int? IdenRptCertificadoConcepto { get; set; }
        public int? IdenEscenariosRetenciones { get; set; }

        public virtual RptCertificadoConcepto? IdenRptCertificadoConceptoNavigation { get; set; }
    }
}
