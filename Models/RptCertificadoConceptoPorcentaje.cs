using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RptCertificadoConceptoPorcentaje
    {
        public int Iden { get; set; }
        public int? IdenRptCertificadoConcepto { get; set; }
        public double? Porcentaje { get; set; }

        public virtual RptCertificadoConcepto? IdenRptCertificadoConceptoNavigation { get; set; }
    }
}
