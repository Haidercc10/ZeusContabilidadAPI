using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CombinacionTiposEmpresa
    {
        public decimal CodigoCombinacion { get; set; }
        public string TipoEmpresaLocal { get; set; } = null!;
        public string TipoEmpresaExterna { get; set; } = null!;
        public byte[] VersionDeLaFila { get; set; } = null!;

        public virtual TiposDeEmpresa TipoEmpresaExternaNavigation { get; set; } = null!;
        public virtual TiposDeEmpresa TipoEmpresaLocalNavigation { get; set; } = null!;
    }
}
