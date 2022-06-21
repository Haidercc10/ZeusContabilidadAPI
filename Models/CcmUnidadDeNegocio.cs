using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CcmUnidadDeNegocio
    {
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Habilitado { get; set; } = null!;
        public string? CuentaCompensacion { get; set; }
        public byte? NivelUnidadDeNegocio { get; set; }
        public string? DependenciaUnidadDeNegocio { get; set; }
        public DateTime? FechaUnidadDeNegocio { get; set; }
        public string? TipoUnidadDeNegocio { get; set; }
        public string? CodigoReferencia { get; set; }
    }
}
