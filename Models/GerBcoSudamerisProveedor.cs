using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBcoSudamerisProveedor
    {
        public string? Idprove { get; set; }
        public string Identificacion { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
        public string Banco { get; set; } = null!;
        public string? CodigoTercero { get; set; }
        public string? TipoMatricula { get; set; }
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }
        public int IdenGerbcosudamerisProveedor { get; set; }

        public virtual Tercero? CodigoTerceroNavigation { get; set; }
        public virtual Proveedore? IdproveNavigation { get; set; }
    }
}
