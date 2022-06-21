using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RptCertificadoConcepto
    {
        public int Iden { get; set; }
        public int? IdenRptCertificado { get; set; }
        public string Concepto { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? IdenEscenariosTipoTasa { get; set; }

        public virtual RptCertificado? IdenRptCertificadoNavigation { get; set; }
    }
}
