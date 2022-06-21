using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SriInfoCompRetencion
    {
        public decimal Iden { get; set; }
        public string FechaEmision { get; set; } = null!;
        public string DirEstablecimiento { get; set; } = null!;
        public string ContribuyenteEspecial { get; set; } = null!;
        public string ObligadoContabilidad { get; set; } = null!;
        public string TipoIdentificacionSujetoRetenido { get; set; } = null!;
        public string RazonSocialSujetoRetenido { get; set; } = null!;
        public string IdentificacionSujetoRetenido { get; set; } = null!;
        public string PeriodoFiscal { get; set; } = null!;
        public string ClaveAcceso { get; set; } = null!;
        public decimal IdenXmlRecibido { get; set; }
    }
}
