using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SunatParametro
    {
        public string TipoFacturaNd { get; set; } = null!;
        public string TipoFacturaBv { get; set; } = null!;
        public string NoBoletaVenta { get; set; } = null!;
        public string FechaPresentacion { get; set; } = null!;
        public string TipoFacturaSp { get; set; } = null!;
        public string TipoFacturaLc { get; set; } = null!;
        public string ConceptoIva { get; set; } = null!;
        public string TipoFacturaPs { get; set; } = null!;
        public string FechaRetencion { get; set; } = null!;
        public string NdocRetencion { get; set; } = null!;
        public string? ConceptoRedondeoC { get; set; }
        public int IdenSunatParametros { get; set; }
    }
}
