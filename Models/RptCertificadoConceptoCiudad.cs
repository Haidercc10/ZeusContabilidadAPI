using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RptCertificadoConceptoCiudad
    {
        public int Iden { get; set; }
        public int? IdenRptCertificadoConcepto { get; set; }
        public int? IdenEscenariosCiudad { get; set; }

        public virtual RptCertificadoConcepto? IdenRptCertificadoConceptoNavigation { get; set; }
    }
}
