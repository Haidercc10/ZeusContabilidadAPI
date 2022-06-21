using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CcmCentroCosto
    {
        public string CodigoCentroCosto { get; set; } = null!;
        public string DescripcionCentroCosto { get; set; } = null!;
        public byte NivelCentroCosto { get; set; }
        public string DependenciaCentroCosto { get; set; } = null!;
        public string? TipoCentroCosto { get; set; }
        public string Deshabilitado { get; set; } = null!;
    }
}
